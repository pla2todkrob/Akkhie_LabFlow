using System.Drawing;
using System.Windows.Forms;

namespace LabFlow
{
    /// <summary>
    /// คลาสสำหรับจัดการ Theme และการออกแบบ UI ของโปรแกรม
    /// Centralizes all styling logic for a consistent and modern look.
    /// </summary>
    public static class UITheme
    {
        // ================== Color Palette ==================
        public static Color PrimaryColor { get; } = Color.FromArgb(0, 123, 255);
        public static Color PrimaryColor_Hover { get; } = Color.FromArgb(0, 105, 217);
        public static Color SecondaryColor { get; } = Color.FromArgb(108, 117, 125);
        public static Color SecondaryColor_Hover { get; } = Color.FromArgb(92, 99, 106);
        public static Color BackgroundColor { get; } = Color.FromArgb(248, 249, 250);
        public static Color CardBackgroundColor { get; } = Color.White;
        public static Color TextColor { get; } = Color.FromArgb(33, 37, 41);
        public static Color BorderColor { get; } = Color.FromArgb(222, 226, 230);
        public static Color ReadOnlyColor { get; } = Color.FromArgb(233, 236, 239); // สีสำหรับ ReadOnly

        // ================== Fonts ==================
        public static Font MainFont { get; } = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        public static Font HeaderFont { get; } = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        public static Font LabelFont { get; } = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

        /// <summary>
        /// ใช้ Theme หลักกับฟอร์ม
        /// </summary>
        public static void ApplyThemeToForm(Form form)
        {
            form.BackColor = BackgroundColor;
            form.Font = MainFont;
            form.ForeColor = TextColor;
        }

        /// <summary>
        /// ปรับสไตล์ของปุ่มให้ทันสมัย
        /// </summary>
        public static void StyleButton(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.Height = 35;

            Color backColor = isPrimary ? PrimaryColor : SecondaryColor;
            Color hoverColor = isPrimary ? PrimaryColor_Hover : SecondaryColor_Hover;

            btn.BackColor = backColor;

            // Hover effects
            btn.MouseEnter -= OnButtonEnter;
            btn.MouseLeave -= OnButtonLeave;
            btn.MouseEnter += OnButtonEnter;
            btn.MouseLeave += OnButtonLeave;

            // Store original colors in Tag property
            btn.Tag = new { BackColor = backColor, HoverColor = hoverColor };
        }

        private static void OnButtonEnter(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                dynamic colors = btn.Tag;
                btn.BackColor = colors.HoverColor;
            }
        }

        private static void OnButtonLeave(object sender, System.EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                dynamic colors = btn.Tag;
                btn.BackColor = colors.BackColor;
            }
        }

        /// <summary>
        /// ปรับสไตล์ของ Label
        /// </summary>
        public static void StyleLabel(Label lbl)
        {
            lbl.Font = LabelFont;
            lbl.ForeColor = TextColor;
            lbl.Anchor = AnchorStyles.Left;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// ปรับสไตล์ของ TextBox
        /// </summary>
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = MainFont;
            txt.ForeColor = TextColor;

            // Set background color based on ReadOnly state
            txt.BackColor = txt.ReadOnly ? ReadOnlyColor : CardBackgroundColor;
        }

        /// <summary>
        /// ปรับสไตล์ของ CheckBox
        /// </summary>
        public static void StyleCheckBox(CheckBox chk)
        {
            chk.Font = LabelFont;
            chk.ForeColor = TextColor;
        }

        /// <summary>
        /// ปรับสไตล์ของ StatusStrip
        /// </summary>
        public static void StyleStatusStrip(StatusStrip strip)
        {
            strip.BackColor = CardBackgroundColor;
            strip.Font = LabelFont;
            strip.ForeColor = TextColor;
            strip.Padding = new Padding(strip.Padding.Left, 0, strip.Padding.Right, 0);
        }
    }
}
