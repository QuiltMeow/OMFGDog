using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OMFGDog
{
    public partial class OMFGDogFull : Form
    {
        private static bool allowExit = true;

        public OMFGDogFull()
        {
            InitializeComponent();
            initBorder();
            fullDog();
        }

        private void initBorder()
        {
            int borderX = Screen.PrimaryScreen.Bounds.Width;
            int borderY = Screen.PrimaryScreen.Bounds.Height;
            Size = new Size(borderX, borderY);
        }

        private void exitProgram()
        {
            Environment.Exit(1);
        }

        private string extractDog()
        {
            string path = Path.Combine(Path.GetTempPath(), "OMFGDog.gif");
            ImageConverter convert = new ImageConverter();
            try
            {
                File.WriteAllBytes(path, (byte[])convert.ConvertTo(Properties.Resources.OMFGDog, typeof(byte[])));
            }
            catch
            {
                exitProgram();
            }
            return path;
        }

        private string buildHTML(string file)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("    <head>");
            sb.AppendLine("        <meta charset=\"UTF-8\">");
            sb.AppendLine("        <title>OMFGDog</title>");
            sb.AppendLine("        <style>");
            sb.AppendLine("            body {");
            sb.Append("                background-image: url(\"").Append(file.Replace("\\", "\\\\")).AppendLine("\");");
            sb.AppendLine("                background-repeat: repeat;");
            sb.AppendLine("            }");
            sb.AppendLine("        </style>");
            sb.AppendLine("    </head>");
            sb.AppendLine("    <body>");
            sb.AppendLine("    </body>");
            sb.AppendLine("</html>");
            return sb.ToString();
        }

        private void wbOMFGDog_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (allowExit && e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void OMFGDogFull_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitProgram();
        }

        private void timerTopMost_Tick(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void fullDog()
        {
            wbOMFGDog.DocumentText = buildHTML(extractDog());
        }

        public static void setAllowExit(bool allow)
        {
            allowExit = allow;
        }
    }
}