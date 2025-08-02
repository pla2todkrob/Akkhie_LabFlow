using System;
using System.Windows.Forms;
using LabFlow.Models;

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
            SetupInitialState();
        }

        private void SetupInitialState()
        {
            ToggleControls(false);
            statusLabel.Text = "กรุณากรอก 'เลขที่ของเสีย' แล้วกดค้นหา";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string wasteNo = txtWasteNo.Text.Trim();
            if (string.IsNullOrEmpty(wasteNo))
            {
                MessageBox.Show("กรุณากรอกเลขที่ของเสีย", "ข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            statusLabel.Text = "กำลังค้นหาข้อมูล...";
            this.Cursor = Cursors.WaitCursor;
            currentWasteDataID = string.Empty;
            ClearForm();

            try
            {
                string wasteDataId = await DatabaseHelper.GetWasteDataID(wasteNo);

                if (!string.IsNullOrEmpty(wasteDataId))
                {
                    currentWasteDataID = wasteDataId;
                    WasteDataLabModel labData = await DatabaseHelper.GetWasteDataLab(currentWasteDataID);

                    if (labData != null)
                    {
                        PopulateForm(labData);
                        ToggleControls(true);
                        statusLabel.Text = $"พบข้อมูลสำหรับ Waste No: {wasteNo}";
                    }
                    else
                    {
                        ToggleControls(true);
                        txtAnalysisNo.Text = "N/A - ข้อมูลใหม่";
                        statusLabel.Text = $"ไม่พบผลวิเคราะห์สำหรับ Waste No: {wasteNo} (สามารถกรอกข้อมูลใหม่ได้)";
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบเลขที่ของเสียนี้ในระบบ", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToggleControls(false);
                    statusLabel.Text = "ไม่พบข้อมูล กรุณาลองใหม่อีกครั้ง";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "เกิดข้อผิดพลาด";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentWasteDataID))
            {
                MessageBox.Show("กรุณาค้นหาข้อมูลก่อนทำการบันทึก", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        DialogResult clearResult = MessageBox.Show(
                            "บันทึกข้อมูลเรียบร้อยแล้ว\n\nคุณต้องการล้างข้อมูลในฟอร์มเพื่อเริ่มรายการใหม่หรือไม่?",
                            "สำเร็จ",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (clearResult == DialogResult.Yes)
                        {
                            btnClear_Click(sender, e);
                        }
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
            txtWasteNo.Clear();
            txtWasteNo.Focus();
            statusLabel.Text = "กรุณากรอก 'เลขที่ของเสีย' แล้วกดค้นหา";
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
            foreach (Control c in dataLayout.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control input in c.Controls)
                    {
                        if (input is TextBox)
                            ((TextBox)input).Clear();
                        else if (input is CheckBox)
                            ((CheckBox)input).Checked = false;
                    }
                }
            }
        }

        private void ToggleControls(bool enabled)
        {
            dataLayout.Enabled = enabled;
            btnSave.Enabled = enabled;
        }
    }
}
