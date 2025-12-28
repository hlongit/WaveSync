using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer.Resources {
    public class RoundedPanel : Panel {
        public int BorderRadius { get; set; } = 20;

        public RoundedPanel() {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true; // Tells the panel to redraw itself when resized
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);

            if (this.DesignMode) return;

            // Apply the Rounded Region
            using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, BorderRadius)) {
                // Prevent memory leak by disposing the old region if it exists
                if (this.Region != null) this.Region.Dispose();
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            if (this.DesignMode) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Optional: Draw a border to hide jagged edges (Aliasing) from the Region cut
            // Using parent color or specific border color looks better than BackColor
            using (Pen pen = new Pen(this.BackColor, 1.5f)) {
                e.Graphics.DrawPath(pen, GetRoundedPath(this.ClientRectangle, BorderRadius));
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
            GraphicsPath path = new GraphicsPath();
            // Simple validation to prevent crash if radius is too big for the box
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