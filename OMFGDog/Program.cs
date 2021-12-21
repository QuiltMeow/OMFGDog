using System;
using System.Threading;
using System.Windows.Forms;

namespace OMFGDog
{
    public static class Program
    {
        public static readonly Random random = new Random();

        private static StartType st = StartType.FULL_SCREEN;

        private static void BGMThread()
        {
            Application.Run(new OMFGDogMP3Player());
        }

        private static void dogThread()
        {
            Application.Run(new OMFGDog());
        }

        public static void setStartType(StartType type)
        {
            st = type;
        }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                if (args[0].Equals("move", StringComparison.InvariantCultureIgnoreCase))
                {
                    st = StartType.MOVE;
                }
            }

            new Thread(BGMThread).Start();
            ThreadPool.SetMaxThreads(8, 8);
            if (st == StartType.MOVE)
            {
                while (true)
                {
                    if (random.Next(100) < 70)
                    {
                        ThreadPool.QueueUserWorkItem(callback =>
                        {
                            dogThread();
                        });
                    }
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Application.Run(new OMFGDogFull());
            }
        }
    }
}