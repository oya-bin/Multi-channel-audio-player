using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_01
{
    public static class Conf_s
    {
        public const float fSqrt = 1.41421356f;
        public const float fPI = 3.1415926f;
        public const float fPIrad = 0.017453292f;
        public const float fPIdo = 57.295779f;
        public static long ms_freq = System.Diagnostics.Stopwatch.Frequency / 1000;
        public const double PIrad = Math.PI / 180.0;
        public const double PIdo = 180.0 / Math.PI;
        public const float EPS = 0.000001f;
        //public static IntPtr handle = (IntPtr)0;
        public static string path = Environment.CurrentDirectory+"\\data";
    }
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            System.Threading.ThreadPool.GetMinThreads(out int workMin, out int ioMin);
            System.Threading.ThreadPool.SetMinThreads(20, ioMin);
            Form frm = new Form1();
            frm.ShowDialog();
        }
    }
}
