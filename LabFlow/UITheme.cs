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
        public static Color HeaderColor { get; } = Color.FromArgb(0, 123, 255);

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
            btn.Height = 35; // Set a consistent height

            Color backColor = isPrimary ? PrimaryColor : SecondaryColor;
            Color hoverColor = isPrimary ? PrimaryColor_Hover : SecondaryColor_Hover;

            btn.BackColor = backColor;

            // Hover effects
            btn.MouseEnter += (sender, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (sender, e) => btn.BackColor = backColor;
        }

        /// <summary>
        /// ปรับสไตล์ของ Panel ให้เป็นการ์ด (แทน GroupBox)
        /// </summary>
        public static void StylePanelAsCard(Panel panel, string title)
        {
            panel.BackColor = CardBackgroundColor;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Padding = new Padding(15, 45, 15, 15); // Top padding for header

            // Add a custom border color
            panel.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid);
            };

            // Add a title label to act as the header
            Label headerLabel = new Label
            {
                Text = title,
                Font = HeaderFont,
                ForeColor = TextColor,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(15, 0, 0, 0)
            };

            // Add a line under the header
            Label line = new Label
            {
                Height = 1,
                Dock = DockStyle.Top,
                BackColor = BorderColor,
                Margin = new Padding(0, 0, 0, 10) // Margin below the line
            };

            panel.Controls.Add(line);
            panel.Controls.Add(headerLabel);
            line.BringToFront();
            headerLabel.BringToFront();
        }

        /// <summary>
        /// ปรับสไตล์ของ Label
        /// </summary>
        public static void StyleLabel(Label lbl)
        {
            lbl.Font = LabelFont;
            lbl.ForeColor = TextColor;
        }

        /// <summary>
        /// ปรับสไตล์ของ TextBox
        /// </summary>
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = CardBackgroundColor;
            txt.ForeColor = TextColor;
            txt.Font = MainFont;

            // Add custom border color
            txt.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, txt.ClientRectangle,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid,
                    BorderColor, 1, ButtonBorderStyle.Solid);
            };
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
