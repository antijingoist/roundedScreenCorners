using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rounded
{
    public partial class roundedCornersForm : Form
    {
        public roundedCornersForm()
        {
            InitializeComponent();
        }

        private void roundedCornersForm_Load(object sender, EventArgs e)
        {
            drawRoundedCorners();
        }
        private void drawRoundedCorners()
        {
            roundedCornerFramePictureBox.Image = null;
            GraphicsPath roundedRectPath = new GraphicsPath();
            Rectangle rectanglePath = new Rectangle(0, 0, roundedCornerFramePictureBox.Width, roundedCornerFramePictureBox.Height);
            int roundedCornerDiameter = 50;

            roundedRectPath.AddArc(rectanglePath.X, rectanglePath.Y, roundedCornerDiameter, roundedCornerDiameter, 180, 90);

            roundedRectPath.AddArc(rectanglePath.X + rectanglePath.Width - roundedCornerDiameter,
                                    rectanglePath.Y, roundedCornerDiameter, roundedCornerDiameter, 270, 90);

            roundedRectPath.AddArc(rectanglePath.X + rectanglePath.Width - roundedCornerDiameter,
                                    rectanglePath.Y + rectanglePath.Height - roundedCornerDiameter,
                                    roundedCornerDiameter, roundedCornerDiameter, 0, 90);

            roundedRectPath.AddArc(rectanglePath.X, rectanglePath.Y + rectanglePath.Height - roundedCornerDiameter,
                                    roundedCornerDiameter, roundedCornerDiameter, 90, 90);

            roundedCornerFramePictureBox.Region = new Region(roundedRectPath);
        }

        private void roundedCornersForm_SizeChanged(object sender, EventArgs e)
        {
            drawRoundedCorners();
        }
    }
}
