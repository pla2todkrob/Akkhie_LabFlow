namespace LabFlow
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.txtSamplingByNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSamplingBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnalysisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPhysical = new System.Windows.Forms.Panel();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSolidContent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSludgeContent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAshContent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWaterContent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoistureContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBulkdensity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtViscosity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhysicalstate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelChemical = new System.Windows.Forms.Panel();
            this.txtConcentrate = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAlkalinity = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAcidity = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDrybasisContent = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNitrogenContent = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelReaction = new System.Windows.Forms.Panel();
            this.chkCyanide = new System.Windows.Forms.CheckBox();
            this.chkNitrite = new System.Windows.Forms.CheckBox();
            this.chkFreeChlorine = new System.Windows.Forms.CheckBox();
            this.panelHeat = new System.Windows.Forms.Panel();
            this.txtNCVValue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHeatingValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelHeavyMetal = new System.Windows.Forms.Panel();
            this.txtCu = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtZn = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtMn = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtNi = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTDS = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtHeavyFe = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtHeavyPb = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtHeavyHg = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtHeavyCr = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtHeavyCd = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtHeavyAs = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.springLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.userManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTableLayout.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.dataLayout.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.panelPhysical.SuspendLayout();
            this.panelChemical.SuspendLayout();
            this.panelReaction.SuspendLayout();
            this.panelHeat.SuspendLayout();
            this.panelHeavyMetal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.panelBottom, 0, 1);
            this.mainTableLayout.Controls.Add(this.dataLayout, 0, 0);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayout.Size = new System.Drawing.Size(1008, 707);
            this.mainTableLayout.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoSize = true;
            this.panelBottom.BackColor = System.Drawing.Color.White;
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelBottom.Location = new System.Drawing.Point(0, 636);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(15);
            this.panelBottom.Size = new System.Drawing.Size(1008, 71);
            this.panelBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(885, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "บันทึกข้อมูล";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(789, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "ล้างข้อมูล";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataLayout
            // 
            this.dataLayout.AutoScroll = true;
            this.dataLayout.ColumnCount = 3;
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataLayout.Controls.Add(this.panelGeneral, 0, 0);
            this.dataLayout.Controls.Add(this.panelPhysical, 1, 1);
            this.dataLayout.Controls.Add(this.panelChemical, 2, 1);
            this.dataLayout.Controls.Add(this.panelReaction, 1, 2);
            this.dataLayout.Controls.Add(this.panelHeat, 2, 2);
            this.dataLayout.Controls.Add(this.panelHeavyMetal, 0, 1);
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(3, 3);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.Padding = new System.Windows.Forms.Padding(12);
            this.dataLayout.RowCount = 3;
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.dataLayout.Size = new System.Drawing.Size(1002, 630);
            this.dataLayout.TabIndex = 2;
            // 
            // panelGeneral
            // 
            this.dataLayout.SetColumnSpan(this.panelGeneral, 3);
            this.panelGeneral.Controls.Add(this.txtSamplingByNo);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.txtSamplingBy);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.txtAnalysisNo);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneral.Location = new System.Drawing.Point(15, 15);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(972, 100);
            this.panelGeneral.TabIndex = 0;
            // 
            // txtSamplingByNo
            // 
            this.txtSamplingByNo.Location = new System.Drawing.Point(768, 59);
            this.txtSamplingByNo.Name = "txtSamplingByNo";
            this.txtSamplingByNo.Size = new System.Drawing.Size(180, 25);
            this.txtSamplingByNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "เลขที่ใบอนุญาต:";
            // 
            // txtSamplingBy
            // 
            this.txtSamplingBy.Location = new System.Drawing.Point(448, 59);
            this.txtSamplingBy.Name = "txtSamplingBy";
            this.txtSamplingBy.Size = new System.Drawing.Size(180, 25);
            this.txtSamplingBy.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ผู้เก็บตัวอย่าง:";
            // 
            // txtAnalysisNo
            // 
            this.txtAnalysisNo.Location = new System.Drawing.Point(127, 59);
            this.txtAnalysisNo.Name = "txtAnalysisNo";
            this.txtAnalysisNo.ReadOnly = true;
            this.txtAnalysisNo.Size = new System.Drawing.Size(180, 25);
            this.txtAnalysisNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลขที่วิเคราะห์:";
            // 
            // panelPhysical
            // 
            this.panelPhysical.Controls.Add(this.txtSS);
            this.panelPhysical.Controls.Add(this.label13);
            this.panelPhysical.Controls.Add(this.txtSolidContent);
            this.panelPhysical.Controls.Add(this.label12);
            this.panelPhysical.Controls.Add(this.txtSludgeContent);
            this.panelPhysical.Controls.Add(this.label11);
            this.panelPhysical.Controls.Add(this.txtAshContent);
            this.panelPhysical.Controls.Add(this.label10);
            this.panelPhysical.Controls.Add(this.txtWaterContent);
            this.panelPhysical.Controls.Add(this.label9);
            this.panelPhysical.Controls.Add(this.txtMoistureContent);
            this.panelPhysical.Controls.Add(this.label8);
            this.panelPhysical.Controls.Add(this.txtBulkdensity);
            this.panelPhysical.Controls.Add(this.label7);
            this.panelPhysical.Controls.Add(this.txtViscosity);
            this.panelPhysical.Controls.Add(this.label6);
            this.panelPhysical.Controls.Add(this.txtPhysicalstate);
            this.panelPhysical.Controls.Add(this.label5);
            this.panelPhysical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhysical.Location = new System.Drawing.Point(346, 126);
            this.panelPhysical.Margin = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.panelPhysical.Name = "panelPhysical";
            this.panelPhysical.Size = new System.Drawing.Size(310, 286);
            this.panelPhysical.TabIndex = 2;
            // 
            // txtSS
            // 
            this.txtSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSS.Location = new System.Drawing.Point(145, 270);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(150, 25);
            this.txtSS.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Suspended solids:";
            // 
            // txtSolidContent
            // 
            this.txtSolidContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolidContent.Location = new System.Drawing.Point(145, 239);
            this.txtSolidContent.Name = "txtSolidContent";
            this.txtSolidContent.Size = new System.Drawing.Size(150, 25);
            this.txtSolidContent.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "ปริมาณของแข็ง:";
            // 
            // txtSludgeContent
            // 
            this.txtSludgeContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSludgeContent.Location = new System.Drawing.Point(145, 208);
            this.txtSludgeContent.Name = "txtSludgeContent";
            this.txtSludgeContent.Size = new System.Drawing.Size(150, 25);
            this.txtSludgeContent.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "ปริมาณสลัดจ์:";
            // 
            // txtAshContent
            // 
            this.txtAshContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAshContent.Location = new System.Drawing.Point(145, 177);
            this.txtAshContent.Name = "txtAshContent";
            this.txtAshContent.Size = new System.Drawing.Size(150, 25);
            this.txtAshContent.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "ปริมาณเถ้า:";
            // 
            // txtWaterContent
            // 
            this.txtWaterContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWaterContent.Location = new System.Drawing.Point(145, 146);
            this.txtWaterContent.Name = "txtWaterContent";
            this.txtWaterContent.Size = new System.Drawing.Size(150, 25);
            this.txtWaterContent.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "ปริมาณน้ำ:";
            // 
            // txtMoistureContent
            // 
            this.txtMoistureContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoistureContent.Location = new System.Drawing.Point(145, 115);
            this.txtMoistureContent.Name = "txtMoistureContent";
            this.txtMoistureContent.Size = new System.Drawing.Size(150, 25);
            this.txtMoistureContent.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "ค่าความชื้น:";
            // 
            // txtBulkdensity
            // 
            this.txtBulkdensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBulkdensity.Location = new System.Drawing.Point(145, 84);
            this.txtBulkdensity.Name = "txtBulkdensity";
            this.txtBulkdensity.Size = new System.Drawing.Size(150, 25);
            this.txtBulkdensity.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "ความหนาแน่น:";
            // 
            // txtViscosity
            // 
            this.txtViscosity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViscosity.Location = new System.Drawing.Point(145, 53);
            this.txtViscosity.Name = "txtViscosity";
            this.txtViscosity.Size = new System.Drawing.Size(150, 25);
            this.txtViscosity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "ความหนืด:";
            // 
            // txtPhysicalstate
            // 
            this.txtPhysicalstate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhysicalstate.Location = new System.Drawing.Point(145, 22);
            this.txtPhysicalstate.Name = "txtPhysicalstate";
            this.txtPhysicalstate.Size = new System.Drawing.Size(150, 25);
            this.txtPhysicalstate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "สถานะ (Phys. state):";
            // 
            // panelChemical
            // 
            this.panelChemical.Controls.Add(this.txtConcentrate);
            this.panelChemical.Controls.Add(this.label23);
            this.panelChemical.Controls.Add(this.txtAlkalinity);
            this.panelChemical.Controls.Add(this.label22);
            this.panelChemical.Controls.Add(this.txtAcidity);
            this.panelChemical.Controls.Add(this.label21);
            this.panelChemical.Controls.Add(this.txtDrybasisContent);
            this.panelChemical.Controls.Add(this.label20);
            this.panelChemical.Controls.Add(this.txtNitrogenContent);
            this.panelChemical.Controls.Add(this.label19);
            this.panelChemical.Controls.Add(this.txtS);
            this.panelChemical.Controls.Add(this.label18);
            this.panelChemical.Controls.Add(this.txtF);
            this.panelChemical.Controls.Add(this.label17);
            this.panelChemical.Controls.Add(this.txtCL);
            this.panelChemical.Controls.Add(this.label16);
            this.panelChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChemical.Location = new System.Drawing.Point(672, 126);
            this.panelChemical.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.panelChemical.Name = "panelChemical";
            this.panelChemical.Size = new System.Drawing.Size(315, 286);
            this.panelChemical.TabIndex = 4;
            // 
            // txtConcentrate
            // 
            this.txtConcentrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcentrate.Location = new System.Drawing.Point(159, 270);
            this.txtConcentrate.Name = "txtConcentrate";
            this.txtConcentrate.Size = new System.Drawing.Size(138, 25);
            this.txtConcentrate.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 273);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(114, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "ความเข้มข้นกรด/ด่าง:";
            // 
            // txtAlkalinity
            // 
            this.txtAlkalinity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlkalinity.Location = new System.Drawing.Point(159, 239);
            this.txtAlkalinity.Name = "txtAlkalinity";
            this.txtAlkalinity.Size = new System.Drawing.Size(138, 25);
            this.txtAlkalinity.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 12;
            this.label22.Text = "Alkalinity:";
            // 
            // txtAcidity
            // 
            this.txtAcidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcidity.Location = new System.Drawing.Point(159, 208);
            this.txtAcidity.Name = "txtAcidity";
            this.txtAcidity.Size = new System.Drawing.Size(138, 25);
            this.txtAcidity.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 10;
            this.label21.Text = "Acidity:";
            // 
            // txtDrybasisContent
            // 
            this.txtDrybasisContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrybasisContent.Location = new System.Drawing.Point(159, 177);
            this.txtDrybasisContent.Name = "txtDrybasisContent";
            this.txtDrybasisContent.Size = new System.Drawing.Size(138, 25);
            this.txtDrybasisContent.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 17);
            this.label20.TabIndex = 8;
            this.label20.Text = "Dry basis:";
            // 
            // txtNitrogenContent
            // 
            this.txtNitrogenContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNitrogenContent.Location = new System.Drawing.Point(159, 146);
            this.txtNitrogenContent.Name = "txtNitrogenContent";
            this.txtNitrogenContent.Size = new System.Drawing.Size(138, 25);
            this.txtNitrogenContent.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "ไนโตรเจน:";
            // 
            // txtS
            // 
            this.txtS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtS.Location = new System.Drawing.Point(159, 115);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(138, 25);
            this.txtS.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "ซัลเฟอร์:";
            // 
            // txtF
            // 
            this.txtF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF.Location = new System.Drawing.Point(159, 84);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(138, 25);
            this.txtF.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "ฟลูออรีน:";
            // 
            // txtCL
            // 
            this.txtCL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCL.Location = new System.Drawing.Point(159, 53);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(138, 25);
            this.txtCL.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "คลอรีน:";
            // 
            // panelReaction
            // 
            this.panelReaction.Controls.Add(this.chkCyanide);
            this.panelReaction.Controls.Add(this.chkNitrite);
            this.panelReaction.Controls.Add(this.chkFreeChlorine);
            this.panelReaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReaction.Location = new System.Drawing.Point(346, 423);
            this.panelReaction.Margin = new System.Windows.Forms.Padding(8, 3, 8, 8);
            this.panelReaction.Name = "panelReaction";
            this.panelReaction.Size = new System.Drawing.Size(310, 187);
            this.panelReaction.TabIndex = 1;
            // 
            // chkCyanide
            // 
            this.chkCyanide.AutoSize = true;
            this.chkCyanide.Location = new System.Drawing.Point(21, 93);
            this.chkCyanide.Name = "chkCyanide";
            this.chkCyanide.Size = new System.Drawing.Size(73, 21);
            this.chkCyanide.TabIndex = 2;
            this.chkCyanide.Text = "ไซยาไนด์";
            this.chkCyanide.UseVisualStyleBackColor = true;
            // 
            // chkNitrite
            // 
            this.chkNitrite.AutoSize = true;
            this.chkNitrite.Location = new System.Drawing.Point(21, 66);
            this.chkNitrite.Name = "chkNitrite";
            this.chkNitrite.Size = new System.Drawing.Size(64, 21);
            this.chkNitrite.TabIndex = 1;
            this.chkNitrite.Text = "ไนไตรท์";
            this.chkNitrite.UseVisualStyleBackColor = true;
            // 
            // chkFreeChlorine
            // 
            this.chkFreeChlorine.AutoSize = true;
            this.chkFreeChlorine.Location = new System.Drawing.Point(21, 39);
            this.chkFreeChlorine.Name = "chkFreeChlorine";
            this.chkFreeChlorine.Size = new System.Drawing.Size(62, 21);
            this.chkFreeChlorine.TabIndex = 0;
            this.chkFreeChlorine.Text = "คลอรีน";
            this.chkFreeChlorine.UseVisualStyleBackColor = true;
            // 
            // panelHeat
            // 
            this.panelHeat.Controls.Add(this.txtNCVValue);
            this.panelHeat.Controls.Add(this.label15);
            this.panelHeat.Controls.Add(this.txtHeatingValue);
            this.panelHeat.Controls.Add(this.label14);
            this.panelHeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeat.Location = new System.Drawing.Point(672, 423);
            this.panelHeat.Margin = new System.Windows.Forms.Padding(8, 3, 3, 8);
            this.panelHeat.Name = "panelHeat";
            this.panelHeat.Size = new System.Drawing.Size(315, 187);
            this.panelHeat.TabIndex = 3;
            // 
            // txtNCVValue
            // 
            this.txtNCVValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNCVValue.Location = new System.Drawing.Point(142, 89);
            this.txtNCVValue.Name = "txtNCVValue";
            this.txtNCVValue.Size = new System.Drawing.Size(155, 25);
            this.txtNCVValue.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "ค่าความร้อน (NCV):";
            // 
            // txtHeatingValue
            // 
            this.txtHeatingValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeatingValue.Location = new System.Drawing.Point(142, 58);
            this.txtHeatingValue.Name = "txtHeatingValue";
            this.txtHeatingValue.Size = new System.Drawing.Size(155, 25);
            this.txtHeatingValue.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "ค่าความร้อน (GCV):";
            // 
            // panelHeavyMetal
            // 
            this.panelHeavyMetal.Controls.Add(this.txtCu);
            this.panelHeavyMetal.Controls.Add(this.label34);
            this.panelHeavyMetal.Controls.Add(this.txtZn);
            this.panelHeavyMetal.Controls.Add(this.label33);
            this.panelHeavyMetal.Controls.Add(this.txtMn);
            this.panelHeavyMetal.Controls.Add(this.label32);
            this.panelHeavyMetal.Controls.Add(this.txtNi);
            this.panelHeavyMetal.Controls.Add(this.label31);
            this.panelHeavyMetal.Controls.Add(this.txtTDS);
            this.panelHeavyMetal.Controls.Add(this.label30);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyFe);
            this.panelHeavyMetal.Controls.Add(this.label29);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyPb);
            this.panelHeavyMetal.Controls.Add(this.label28);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyHg);
            this.panelHeavyMetal.Controls.Add(this.label27);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyCr);
            this.panelHeavyMetal.Controls.Add(this.label26);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyCd);
            this.panelHeavyMetal.Controls.Add(this.label25);
            this.panelHeavyMetal.Controls.Add(this.txtHeavyAs);
            this.panelHeavyMetal.Controls.Add(this.label24);
            this.panelHeavyMetal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeavyMetal.Location = new System.Drawing.Point(15, 126);
            this.panelHeavyMetal.Margin = new System.Windows.Forms.Padding(3, 3, 8, 8);
            this.panelHeavyMetal.Name = "panelHeavyMetal";
            this.dataLayout.SetRowSpan(this.panelHeavyMetal, 2);
            this.panelHeavyMetal.Size = new System.Drawing.Size(315, 484);
            this.panelHeavyMetal.TabIndex = 5;
            // 
            // txtCu
            // 
            this.txtCu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCu.Location = new System.Drawing.Point(127, 394);
            this.txtCu.Name = "txtCu";
            this.txtCu.Size = new System.Drawing.Size(170, 25);
            this.txtCu.TabIndex = 23;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(18, 397);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 17);
            this.label34.TabIndex = 22;
            this.label34.Text = "ทองแดง:";
            // 
            // txtZn
            // 
            this.txtZn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZn.Location = new System.Drawing.Point(127, 363);
            this.txtZn.Name = "txtZn";
            this.txtZn.Size = new System.Drawing.Size(170, 25);
            this.txtZn.TabIndex = 21;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 366);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 17);
            this.label33.TabIndex = 20;
            this.label33.Text = "สังกะสี:";
            // 
            // txtMn
            // 
            this.txtMn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMn.Location = new System.Drawing.Point(127, 332);
            this.txtMn.Name = "txtMn";
            this.txtMn.Size = new System.Drawing.Size(170, 25);
            this.txtMn.TabIndex = 19;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(18, 335);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 17);
            this.label32.TabIndex = 18;
            this.label32.Text = "แมงกานีส:";
            // 
            // txtNi
            // 
            this.txtNi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNi.Location = new System.Drawing.Point(127, 301);
            this.txtNi.Name = "txtNi";
            this.txtNi.Size = new System.Drawing.Size(170, 25);
            this.txtNi.TabIndex = 17;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 304);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 17);
            this.label31.TabIndex = 16;
            this.label31.Text = "นิเกิล:";
            // 
            // txtTDS
            // 
            this.txtTDS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTDS.Location = new System.Drawing.Point(127, 270);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.Size = new System.Drawing.Size(170, 25);
            this.txtTDS.TabIndex = 15;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(18, 273);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 17);
            this.label30.TabIndex = 14;
            this.label30.Text = "TDS:";
            // 
            // txtHeavyFe
            // 
            this.txtHeavyFe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyFe.Location = new System.Drawing.Point(127, 239);
            this.txtHeavyFe.Name = "txtHeavyFe";
            this.txtHeavyFe.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyFe.TabIndex = 13;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 242);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(36, 17);
            this.label29.TabIndex = 12;
            this.label29.Text = "เหล็ก:";
            // 
            // txtHeavyPb
            // 
            this.txtHeavyPb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyPb.Location = new System.Drawing.Point(127, 208);
            this.txtHeavyPb.Name = "txtHeavyPb";
            this.txtHeavyPb.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyPb.TabIndex = 11;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 211);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 17);
            this.label28.TabIndex = 10;
            this.label28.Text = "ตะกั่ว:";
            // 
            // txtHeavyHg
            // 
            this.txtHeavyHg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyHg.Location = new System.Drawing.Point(127, 177);
            this.txtHeavyHg.Name = "txtHeavyHg";
            this.txtHeavyHg.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyHg.TabIndex = 9;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 180);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "ปรอท:";
            // 
            // txtHeavyCr
            // 
            this.txtHeavyCr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyCr.Location = new System.Drawing.Point(127, 146);
            this.txtHeavyCr.Name = "txtHeavyCr";
            this.txtHeavyCr.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyCr.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 149);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 17);
            this.label26.TabIndex = 6;
            this.label26.Text = "โครเมียม:";
            // 
            // txtHeavyCd
            // 
            this.txtHeavyCd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyCd.Location = new System.Drawing.Point(127, 115);
            this.txtHeavyCd.Name = "txtHeavyCd";
            this.txtHeavyCd.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyCd.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(18, 118);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 17);
            this.label25.TabIndex = 4;
            this.label25.Text = "แคดเมียม:";
            // 
            // txtHeavyAs
            // 
            this.txtHeavyAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeavyAs.Location = new System.Drawing.Point(127, 84);
            this.txtHeavyAs.Name = "txtHeavyAs";
            this.txtHeavyAs.Size = new System.Drawing.Size(170, 25);
            this.txtHeavyAs.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 17);
            this.label24.TabIndex = 2;
            this.label24.Text = "อะเซนิก:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionLabel,
            this.statusLabel,
            this.springLabel,
            this.helpDropDownButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versionLabel
            // 
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(46, 17);
            this.versionLabel.Text = "v1.0.0.0";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // springLabel
            // 
            this.springLabel.Name = "springLabel";
            this.springLabel.Size = new System.Drawing.Size(891, 17);
            this.springLabel.Spring = true;
            // 
            // helpDropDownButton
            // 
            this.helpDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualMenuItem,
            this.devManualMenuItem});
            this.helpDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpDropDownButton.Name = "helpDropDownButton";
            this.helpDropDownButton.Size = new System.Drawing.Size(40, 20);
            this.helpDropDownButton.Text = "คู่มือ";
            // 
            // userManualMenuItem
            // 
            this.userManualMenuItem.Name = "userManualMenuItem";
            this.userManualMenuItem.Size = new System.Drawing.Size(148, 22);
            this.userManualMenuItem.Text = "สำหรับผู้ใช้งาน";
            this.userManualMenuItem.Click += new System.EventHandler(this.userManualMenuItem_Click);
            // 
            // devManualMenuItem
            // 
            this.devManualMenuItem.Name = "devManualMenuItem";
            this.devManualMenuItem.Size = new System.Drawing.Size(148, 22);
            this.devManualMenuItem.Text = "สำหรับนักพัฒนา";
            this.devManualMenuItem.Click += new System.EventHandler(this.devManualMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabFlow - บันทึกผลการวิเคราะห์";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.dataLayout.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelPhysical.ResumeLayout(false);
            this.panelPhysical.PerformLayout();
            this.panelChemical.ResumeLayout(false);
            this.panelChemical.PerformLayout();
            this.panelReaction.ResumeLayout(false);
            this.panelReaction.PerformLayout();
            this.panelHeat.ResumeLayout(false);
            this.panelHeat.PerformLayout();
            this.panelHeavyMetal.ResumeLayout(false);
            this.panelHeavyMetal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel dataLayout;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.TextBox txtSamplingByNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSamplingBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnalysisNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelReaction;
        private System.Windows.Forms.CheckBox chkCyanide;
        private System.Windows.Forms.CheckBox chkNitrite;
        private System.Windows.Forms.CheckBox chkFreeChlorine;
        private System.Windows.Forms.Panel panelPhysical;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSolidContent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSludgeContent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAshContent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWaterContent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoistureContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBulkdensity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtViscosity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhysicalstate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelHeat;
        private System.Windows.Forms.TextBox txtNCVValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHeatingValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelChemical;
        private System.Windows.Forms.TextBox txtConcentrate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAlkalinity;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAcidity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDrybasisContent;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNitrogenContent;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelHeavyMetal;
        private System.Windows.Forms.TextBox txtCu;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtZn;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtMn;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtNi;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtTDS;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtHeavyFe;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtHeavyPb;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtHeavyHg;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtHeavyCr;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtHeavyCd;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtHeavyAs;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel versionLabel;
        private System.Windows.Forms.ToolStripStatusLabel springLabel;
        private System.Windows.Forms.ToolStripDropDownButton helpDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem userManualMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devManualMenuItem;
    }
}
