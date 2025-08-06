using System;
using System.Windows.Forms;

namespace LabFlow
{
    public partial class SearchForm : Form
    {
        // Property สำหรับส่งค่า WasteNo กลับไปให้ MainForm
        public string WasteNo { get; private set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // ใช้ Theme ที่สร้างไว้
            UITheme.ApplyThemeToForm(this);
            UITheme.StyleLabel(labelWasteNo);
            UITheme.StyleTextBox(txtWasteNo);
            UITheme.StyleButton(btnSearch, isPrimary: true);
            UITheme.StyleButton(btnCancel, isPrimary: false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWasteNo.Text))
            {
                MessageBox.Show("กรุณากรอกเลขที่ของเสีย", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // เก็บค่าที่ผู้ใช้กรอก
            this.WasteNo = txtWasteNo.Text.Trim();
            // ตั้งค่า DialogResult เพื่อให้ MainForm รู้ว่าผู้ใช้กด "ค้นหา"
            this.DialogResult = DialogResult.OK;
            // ปิดฟอร์ม
            this.Close();
        }
    }
}
