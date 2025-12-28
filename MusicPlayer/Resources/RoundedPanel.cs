using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer.Resources {
    public class RoundedPanel : Panel {
        public int BorderRadius { get; set; } = 20;
        private GraphicsPath _path;

        public RoundedPanel() {
            this.DoubleBuffered = true;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            _path?.Dispose();
            _path = GetRoundedPath(this.ClientRectangle, BorderRadius);
        }

        protected override void OnPaint(PaintEventArgs e) {
            if (_path == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(this.BackColor)) {
                e.Graphics.FillPath(brush, _path);
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
