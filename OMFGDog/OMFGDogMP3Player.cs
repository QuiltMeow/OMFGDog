using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace OMFGDog
{
    public partial class OMFGDogMP3Player : Form
    {
        private readonly WindowsMediaPlayer wmp;

        public OMFGDogMP3Player()
        {
            InitializeComponent();

            wmp = new WindowsMediaPlayer();
            playBGM();
        }

        private void extractBGM()
        {
            string path = Path.Combine(Path.GetTempPath(), "BGM.mp3");
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                fs.Write(Properties.Resources.BGM, 0, Properties.Resources.BGM.Length);
                fs.Flush();
            }
        }

        public void playBGM()
        {
            try
            {
                extractBGM();
                wmp.URL = Path.Combine(Path.GetTempPath(), "BGM.mp3");
                wmp.settings.volume = 100;
                wmp.settings.setMode("loop", true);
                wmp.controls.play();
            }
            catch
            {
                Environment.Exit(1);
            }
        }

        private void timerHide_Tick(object sender, EventArgs e)
        {
            Hide();
        }
    }
}