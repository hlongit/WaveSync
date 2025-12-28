using System;
using System.ComponentModel; // Required for LicenseManager
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer.Resources {
    public class RoundedPanel : Panel {
        // Define a robust 'IsInDesignMode' property
        private bool IsInDesignMode {
            get {
                if (DesignMode) return true;
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return true;
                // Check if the process is Visual Studio (devenv) just to be safe
                if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv") return true;
                return false;
            }
        }

        public int BorderRadius { get; set; } = 20;

        public RoundedPanel() {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);

            // Use the robust check
            if (IsInDesignMode) return;

            // Apply Region only at runtime
            using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, BorderRadius)) {
                if (this.Region != null) this.Region.Dispose();
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // 3. Draw a placeholder in Designer so it's not invisible
            if (IsInDesignMode) {
                using (Pen p = new Pen(Color.Gray, 1) { DashStyle = DashStyle.Dash }) {
                    e.Graphics.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                }
                return;
            }

            // Runtime drawing
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(this.BackColor, 1.5f)) {
                e.Graphics.DrawPath(pen, GetRoundedPath(this.ClientRectangle, BorderRadius));
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}