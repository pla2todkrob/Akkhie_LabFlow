using LabFlow.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks; // Add this for Task
using System.Windows.Forms;

namespace LabFlow
{
    public partial class MainForm : Form
    {
        private string currentWasteDataID = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            SetupInitialState();
            DisplayVersion();
            // แสดงฟอร์มค้นหาทันทีเมื่อเปิดโปรแกรม
            ShowSearchForm();
        }

        private void ApplyTheme()
        {
            UITheme.ApplyThemeToForm(this);
            UITheme.StyleButton(btnSave, isPrimary: true);
            UITheme.StyleButton(btnClear, isPrimary: false);
            panelBottom.BackColor = UITheme.CardBackgroundColor;

            // Style all panels as cards with titles
            UITheme.StylePanelAsCard(panelGeneral, "ข้อมูลทั่วไป");
            UITheme.StylePanelAsCard(panelPhysical, "คุณสมบัติทางกายภาพ");
            UITheme.StylePanelAsCard(panelChemical, "องค์ประกอบทางเคมี");
            UITheme.StylePanelAsCard(panelReaction, "ผลการทดสอบปฏิกิริยา");
            UITheme.StylePanelAsCard(panelHeat, "ค่าความร้อน");
            UITheme.StylePanelAsCard(panelHeavyMetal, "โลหะหนักและอื่นๆ");

            var panels = new List<Panel>
            {
                panelGeneral, panelPhysical, panelChemical,
                panelReaction, panelHeat, panelHeavyMetal
            };

            foreach (var panel in panels)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox)
                        UITheme.StyleTextBox(control as TextBox);
                    else if (control is Label)
                        UITheme.StyleLabel(control as Label);
                    else if (control is CheckBox)
                        UITheme.StyleCheckBox(control as CheckBox);
                }
            }

            UITheme.StyleStatusStrip(statusStrip1);
        }

        private void DisplayVersion()
        {
            try
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    versionLabel.Text = $"v{ApplicationDeployment.CurrentDeployment.CurrentVersion}";
                }
                else
                {
                    versionLabel.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}";
                }
            }
            catch (Exception)
            {
                versionLabel.Text = "v-.-.-";
            }
        }

        private void SetupInitialState()
        {
            ToggleControls(false); // ปิดการใช้งานฟอร์มหลักในตอนแรก
            statusLabel.Text = "กรุณาค้นหาข้อมูลเพื่อเริ่มต้น";
        }

        // ฟังก์ชันสำหรับแสดงฟอร์มค้นหา
        private void ShowSearchForm()
        {
            using (SearchForm searchForm = new SearchForm())
            {
                // แสดงฟอร์มเป็น Modal Dialog (ผู้ใช้ต้องปิดฟอร์มนี้ก่อนไปทำอย่างอื่น)
                if (searchForm.ShowDialog(this) == DialogResult.OK)
                {
                    // ถ้าผู้ใช้กด "ค้นหา" ให้เริ่มการค้นหาข้อมูล
                    string wasteNo = searchForm.WasteNo;
                    // ใช้ Task.Run เพื่อไม่ให้ UI ค้างขณะค้นหา
                    Task.Run(() => PerformSearch(wasteNo));
                }
            }
        }

        // ฟังก์ชันสำหรับประมวลผลการค้นหา (แยกออกมาเพื่อให้เรียกใช้แบบ Async ได้)
        private async Task PerformSearch(string wasteNo)
        {
            // ใช้ Invoke เพื่ออัปเดต UI จาก Thread อื่น
            this.Invoke((MethodInvoker)delegate {
                statusLabel.Text = "กำลังค้นหาข้อมูล...";
                this.Cursor = Cursors.WaitCursor;
                currentWasteDataID = string.Empty;
                ClearForm();
            });

            try
            {
                string wasteDataId = await DatabaseHelper.GetWasteDataID(wasteNo);

                if (!string.IsNullOrEmpty(wasteDataId))
                {
                    currentWasteDataID = wasteDataId;
                    WasteDataLabModel labData = await DatabaseHelper.GetWasteDataLab(currentWasteDataID);

                    this.Invoke((MethodInvoker)delegate {
                        if (labData != null)
                        {
                            PopulateForm(labData);
                            statusLabel.Text = $"พบข้อมูลสำหรับ Waste No: {wasteNo}";
                        }
                        else
                        {
                            txtAnalysisNo.Text = "N/A - ข้อมูลใหม่";
                            statusLabel.Text = $"ไม่พบผลวิเคราะห์สำหรับ Waste No: {wasteNo} (สามารถกรอกข้อมูลใหม่ได้)";
                        }
                        ToggleControls(true); // เปิดใช้งานฟอร์มหลัก
                    });
                }
                else
                {
                    MessageBox.Show("ไม่พบเลขที่ของเสียนี้ในระบบ", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Invoke((MethodInvoker)delegate {
                        ToggleControls(false);
                        statusLabel.Text = "ไม่พบข้อมูล กรุณาลองใหม่อีกครั้ง";
                        ShowSearchForm(); // ถ้าไม่พบข้อมูล ให้เปิดหน้าต่างค้นหาอีกครั้ง
                    });
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล: \n" + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Invoke((MethodInvoker)delegate { statusLabel.Text = "การเชื่อมต่อล้มเหลว"; });
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Invoke((MethodInvoker)delegate { statusLabel.Text = "เกิดข้อผิดพลาด"; });
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate { this.Cursor = Cursors.Default; });
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentWasteDataID))
            {
                MessageBox.Show("ไม่มีข้อมูลให้บันทึก กรุณาค้นหาข้อมูลก่อน", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("คุณต้องการบันทึกการเปลี่ยนแปลงใช่หรือไม่?", "ยืนยันการบันทึก", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                statusLabel.Text = "กำลังบันทึกข้อมูล...";
                try
                {
                    WasteDataLabModel dataToSave = ReadDataFromForm();
                    bool success = await DatabaseHelper.SaveWasteDataLab(dataToSave);

                    if (success)
                    {
                        statusLabel.Text = "บันทึกข้อมูลล่าสุดเมื่อ " + DateTime.Now.ToString("HH:mm:ss");
                        MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้", "ล้มเหลว", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusLabel.Text = "เกิดข้อผิดพลาดในการบันทึก";
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            ToggleControls(false);
            statusLabel.Text = "กรุณาค้นหาข้อมูลเพื่อเริ่มต้น";
            ShowSearchForm(); // แสดงฟอร์มค้นหาอีกครั้ง
        }

        private void PopulateForm(WasteDataLabModel data)
        {
            txtAnalysisNo.Text = data.AnalysisNo;
            txtSamplingBy.Text = data.SamplingBy;
            txtSamplingByNo.Text = data.SamplingByNo;
            chkFreeChlorine.Checked = (data.FreeChlorine == "Y");
            chkNitrite.Checked = (data.Nitrite == "Y");
            chkCyanide.Checked = (data.Cyanide == "Y");
            txtPhysicalstate.Text = data.Physicalstate;
            txtViscosity.Text = data.Viscosity;
            txtBulkdensity.Text = data.Bulkdensity;
            txtHeatingValue.Text = data.HeatingValue;
            txtNCVValue.Text = data.NCVValue;
            txtMoistureContent.Text = data.MoistureContent;
            txtWaterContent.Text = data.WaterContent;
            txtAshContent.Text = data.AshContent;
            txtCL.Text = data.CL;
            txtF.Text = data.F;
            txtS.Text = data.S;
            txtSludgeContent.Text = data.SludgeContent;
            txtSolidContent.Text = data.SolidContent;
            txtNitrogenContent.Text = data.NitrogenContent;
            txtDrybasisContent.Text = data.DrybasisContent;
            txtHeavyAs.Text = data.HeavyAs;
            txtHeavyCd.Text = data.HeavyCd;
            txtHeavyCr.Text = data.HeavyCr;
            txtHeavyHg.Text = data.HeavyHg;
            txtHeavyPb.Text = data.HeavyPb;
            txtSS.Text = data.SS;
            txtAcidity.Text = data.Acidity;
            txtAlkalinity.Text = data.Alkalinity;
            txtTDS.Text = data.TDS;
            txtNi.Text = data.Ni;
            txtMn.Text = data.Mn;
            txtZn.Text = data.Zn;
            txtCu.Text = data.Cu;
            txtHeavyFe.Text = data.HeavyFe;
            txtConcentrate.Text = data.Concentrate;
        }

        private WasteDataLabModel ReadDataFromForm()
        {
            return new WasteDataLabModel
            {
                WasteDataID = this.currentWasteDataID,
                AnalysisNo = txtAnalysisNo.Text,
                SamplingBy = txtSamplingBy.Text,
                SamplingByNo = txtSamplingByNo.Text,
                FreeChlorine = chkFreeChlorine.Checked ? "Y" : "N",
                Nitrite = chkNitrite.Checked ? "Y" : "N",
                Cyanide = chkCyanide.Checked ? "Y" : "N",
                Physicalstate = txtPhysicalstate.Text,
                Viscosity = txtViscosity.Text,
                Bulkdensity = txtBulkdensity.Text,
                HeatingValue = txtHeatingValue.Text,
                NCVValue = txtNCVValue.Text,
                MoistureContent = txtMoistureContent.Text,
                WaterContent = txtWaterContent.Text,
                AshContent = txtAshContent.Text,
                CL = txtCL.Text,
                F = txtF.Text,
                S = txtS.Text,
                SludgeContent = txtSludgeContent.Text,
                SolidContent = txtSolidContent.Text,
                NitrogenContent = txtNitrogenContent.Text,
                DrybasisContent = txtDrybasisContent.Text,
                HeavyAs = txtHeavyAs.Text,
                HeavyCd = txtHeavyCd.Text,
                HeavyCr = txtHeavyCr.Text,
                HeavyHg = txtHeavyHg.Text,
                HeavyPb = txtHeavyPb.Text,
                SS = txtSS.Text,
                Acidity = txtAcidity.Text,
                Alkalinity = txtAlkalinity.Text,
                TDS = txtTDS.Text,
                Ni = txtNi.Text,
                Mn = txtMn.Text,
                Zn = txtZn.Text,
                Cu = txtCu.Text,
                HeavyFe = txtHeavyFe.Text,
                Concentrate = txtConcentrate.Text,
            };
        }

        private void ClearForm()
        {
            var panels = new List<Panel>
            {
                panelGeneral, panelPhysical, panelChemical,
                panelReaction, panelHeat, panelHeavyMetal
            };
            foreach (var panel in panels)
            {
                foreach (Control c in panel.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                    else if (c is CheckBox)
                        ((CheckBox)c).Checked = false;
                }
            }
        }

        private void ToggleControls(bool enabled)
        {
            dataLayout.Enabled = enabled;
            panelBottom.Enabled = enabled;
        }

        private void userManualMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument("คู่มือสำหรับผู้ใช้งาน.pdf");
        }

        private void devManualMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocument("คู่มือสำหรับนักพัฒนา.pdf");
        }

        private void OpenDocument(string fileName)
        {
            try
            {
                string docPath = Path.Combine(Application.StartupPath, "Document", fileName);
                if (File.Exists(docPath))
                {
                    Process.Start(docPath);
                }
                else
                {
                    MessageBox.Show($"ไม่พบไฟล์คู่มือ: {fileName}", "ไม่พบไฟล์", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถเปิดคู่มือได้: " + ex.Message, "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
