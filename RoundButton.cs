
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pizza_Ordering
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            var path = new GraphicsPath();
            int radius = 40;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddLine(radius,0,this.Width - radius,0);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(this.Width, radius, this.Width, this.Height - radius);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddLine(this.Width - radius, this.Height, radius, this.Height);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, this.Height - radius, 0, radius);
            path.CloseFigure();

            this.Region = new Region(path);

            base.OnPaint(e);
        }
    }
}
