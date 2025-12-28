using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer.Resources {
    public class RoundedPanel : Panel {
        // Robust check for Designer mode
        private bool IsInDesignMode =>
            DesignMode ||
            LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
            System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToLower().Contains("devenv");

        public int BorderRadius { get; set; } = 20;

        public RoundedPanel() {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);

            // CRITICAL: Designer cannot handle Region manipulation during initialization
            if (IsInDesignMode) return;

            UpdateRegion();
        }

        private void UpdateRegion() {
            try {
                using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, BorderRadius)) {
                    if (this.Region != null) this.Region.Dispose();
                    this.Region = new Region(path);
                }
            }
            catch {
                // Failsafe to prevent crash if geometry logic fails
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            // If in Designer, just draw a simple rectangle with a dashed border
            if (IsInDesignMode) {
                e.Graphics.Clear(this.BackColor);
                using (Pen p = new Pen(Color.DarkGray, 1) { DashStyle = DashStyle.Dash }) {
                    e.Graphics.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                }
                return;
            }

            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(this.BackColor, 1.5f)) {
                e.Graphics.DrawPath(pen, GetRoundedPath(this.ClientRectangle, BorderRadius));
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
            GraphicsPath path = new GraphicsPath();
            int d = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));
            if (d <= 0) d = 1; // Prevent ArgumentException

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}