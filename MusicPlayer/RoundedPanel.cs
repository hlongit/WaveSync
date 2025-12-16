using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class RoundedPanel : Panel
    {
        private int radius = 20;

        public int BorderRadius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.Invalidate(); // vẽ lại
            }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Resize += RoundedPanel_Resize;
        }

        private void RoundedPanel_Resize(object sender, EventArgs e)
        {
            ApplyRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            ApplyRegion();
            base.OnPaint(e);
        }

        private void ApplyRegion()
        {
            if (radius <= 0) return;

            Rectangle rect = this.ClientRectangle;
            int d = radius * 2;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
