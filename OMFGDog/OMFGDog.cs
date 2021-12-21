using System;
using System.Drawing;
using System.Windows.Forms;

namespace OMFGDog
{
    public partial class OMFGDog : Form
    {
        private const int BORDER = 15;

        private int borderX, maxBorder, origin;

        public OMFGDog()
        {
            InitializeComponent();
            initBorder();
            initLocation();
            timerRun.Start();
        }

        ~OMFGDog()
        {
            timerRun.Stop();
        }

        private void initBorder()
        {
            borderX = Screen.PrimaryScreen.Bounds.Width;

            int borderY = Screen.PrimaryScreen.Bounds.Height;
            maxBorder = borderY - pbOMFGDog.Size.Height - BORDER + 1;
            if (BORDER >= maxBorder)
            {
                maxBorder = BORDER + 1;
            }
        }

        private void timerTopMost_Tick(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void pbOMFGDog_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X + 5, origin);
            if (Location.X > borderX + 100)
            {
                Close();
            }
        }

        private void initLocation()
        {
            origin = Program.random.Next(BORDER, maxBorder);
            Location = new Point(-pbOMFGDog.Size.Width - 200, origin);
        }
    }
}