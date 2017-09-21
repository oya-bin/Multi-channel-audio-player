using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace game_01
{
    public partial class Form1 : Form
    {
        private void Create_fold(string path)
        {
            try
            { System.IO.DirectoryInfo di = System.IO.Directory.CreateDirectory(path); }
            catch (Exception) { }
        }
        public Form1()
        {
            InitializeComponent();
            Create_fold(Conf_s.path);
            this.Text = Frm1_c.fullname;
            HScrollBar[] hsb = new HScrollBar[] { Hsb_fc, Hsb_fl, Hsb_fr, Hsb_sub, Hsb_bl, Hsb_br ,Hsb_Master};
            foreach(HScrollBar a in hsb)
            { Hsb_init(a,500); }
        }
        private void Hsb_init(HScrollBar a,int val)
        {
            a.Maximum = 1009;
            a.Minimum = 0;
            if (val > a.Maximum || val < a.Minimum) { a.Value = 500; }
            else { a.Value = val; }
        }
        Xa2_mus xa_mus = null;
        private void But_play_Click(object sender, EventArgs e)
        {
            string path = Folder_sel(Conf_s.path);
            if (path == null) { MessageBox.Show("フォルダがありません"); return; }
            Conf_s.path = path;
            Frm1_c.files = System.IO.Directory.GetFiles(Conf_s.path, "*", System.IO.SearchOption.AllDirectories);
            lb_mus.Items.Clear();
            for (int i=0;i< Frm1_c.files.Length;i++)
            {
                lb_mus.Items.Add(System.IO.Path.GetFileName(Frm1_c.files[i]));
            }
        }
        private string Folder_sel(string path)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog()
            {
                Description = "Select music folder",
                RootFolder = System.Environment.SpecialFolder.MyComputer,
                SelectedPath = path,
                ShowNewFolderButton = false
            };
            string str = null;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            { str = folderBrowserDialog1.SelectedPath; }
            folderBrowserDialog1.Dispose();
            return str;
        }

        private int Play_start(string fil_n)
        {
            if (xa_mus == null) { xa_mus = new Xa2_mus(); }
            else { xa_mus.Dispose(); }
            Set_gb1(false);
            xa_mus.Init(0,Frm1_c.ch);
            byte[] dat = Source_sel(fil_n, out byte[] mono);
            if (dat == null)
            {
                Set_gb1(true);
                return -2;
            }
            byte[] dat2 = null;
            switch (Frm1_c.ch)
            {
                case 2:
                    dat2 = dat;
                    break;
                case 21:
                    dat2 = Audio.Ch2_to_ch21(dat, cb_bsidrev.Checked, mono);
                    break;
                case 4:
                    dat2 = Audio.Ch2_to_ch4(dat, cb_bsidrev.Checked, Rb_surround.Checked);
                    break;
                case 5:
                    dat2 = Audio.Ch2_to_ch5(dat, cb_bsidrev.Checked, mono, Rb_surround.Checked);
                    break;
                case 51:
                    dat2 = Audio.Ch2_to_ch51(dat, cb_bsidrev.Checked, mono, Rb_surround.Checked);
                    break;
            }
            Set_array_vol(Frm1_c.ch);
            xa_mus.Step1(dat2, false, Frm1_c.vol_master, Frm1_c.ch);
            if (xa_mus.Play_exe(0) == -1)
            {
                MessageBox.Show("Bad Speakers"); xa_mus.Dispose();
                Set_gb1(true);
                return -1;
            }
            Wait_task();
            return 0;
        }
        Task Waittsk = null;
        private void Wait_task()
        {
            Waittsk = Task.Run(() =>
            {
                while(true)
                {
                    if (!xa_mus.mus_start[0] || Frm1_c.mus_exit) { return; }
                    System.Threading.Thread.Sleep(250);
                }
            });
        }
        private void Rb_51ch_CheckedChanged(object sender, EventArgs e)
        {
            Frm1_c.ch = 51;
            Gb_fro_cen.Enabled = Gb_fro_lef.Enabled = Gb_fro_rig.Enabled = Gb_bak_lef.Enabled = Gb_bak_Rig.Enabled = Gb_sub.Enabled = true;
        }
        private void Rb_5ch_CheckedChanged(object sender, EventArgs e)
        {
            Frm1_c.ch = 5;
            Gb_sub.Enabled = false;
            Gb_fro_cen.Enabled = Gb_fro_lef.Enabled = Gb_fro_rig.Enabled = Gb_bak_lef.Enabled = Gb_bak_Rig.Enabled = true;
        }
        private void Rb_4ch_CheckedChanged(object sender, EventArgs e)
        {
            Frm1_c.ch = 4;
            Gb_fro_cen.Enabled  = Gb_sub.Enabled = false;
            Gb_fro_lef.Enabled = Gb_fro_rig.Enabled = Gb_bak_lef.Enabled = Gb_bak_Rig.Enabled = true;
        }

        private void Rb_21ch_CheckedChanged(object sender, EventArgs e)
        {
            Frm1_c.ch = 21;
            Gb_fro_cen.Enabled = Gb_bak_lef.Enabled = Gb_bak_Rig.Enabled = false;
            Gb_fro_lef.Enabled = Gb_fro_rig.Enabled = Gb_sub.Enabled = true;
        }
        private void Rb_2ch_CheckedChanged(object sender, EventArgs e)
        {
            Frm1_c.ch = 2;
            Gb_fro_cen.Enabled = Gb_bak_lef.Enabled = Gb_bak_Rig.Enabled = Gb_sub.Enabled = false;
            Gb_fro_lef.Enabled = Gb_fro_rig.Enabled = true;
        }

        private void But_stop_Click(object sender, EventArgs e)
        {
            try { xa_mus.Dispose(); }
            catch (Exception) { }
            Set_gb1(true);
            Frm1_c.mus_exit = true;
            lb_mus.Enabled = true;
            Task.Run(() => { GC.Collect(); });
            Frm1_c.lock_list = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm1_c.mus_exit = true;
            Frm1_c.lock_list = false;
            try { xa_mus.Dispose(); }
            catch (Exception) { }
        }

        private byte[] Source_sel(string fil_n, out byte[] mono)
        {
            mono = null;
            string str = System.IO.Path.GetExtension(fil_n);
            switch (str.ToLower())
            {
                case ".flac":
                case ".fla":
                    return Audio.Flac_to_wav(fil_n, 2, out mono);
                case ".ogg":
                case ".oga":
                case ".ogx":
                    return Audio.Ogg_to_wav(fil_n, 2, out mono);
                case ".wma":
                    return Audio.Wma_to_wav(fil_n, 2, out mono);
                case ".mp3":
                    return Audio.Mp3_to_wav(fil_n, 2, out mono);
                case ".wav":
                    return Audio.Wav_to_wav2(fil_n, 2, out mono);
                case ".aiff":
                case ".aif":
                case ".aifc":
                case ".afc":
                    return Audio.Aiff_to_wav(fil_n, 2, out mono);
                default:
                    return null;
            }
        }
        private void Set_array_vol(int ch)
        {
            float[] ret_val = new float[6];
            HScrollBar[] hsb = new HScrollBar[] { Hsb_fl, Hsb_fr, Hsb_fc, Hsb_sub, Hsb_bl, Hsb_br, Hsb_Master };
            for (int i=0;i<ret_val.Length;i++)
            {
                if (hsb[i].Value == 0) { ret_val[i] = 0; continue; }
                ret_val[i] = (float)Math.Log((double)hsb[i].Value, 1000.0);
            }
            Frm1_c.vol_master = (float)hsb[6].Value / 1000f;
            switch (Frm1_c.ch)
            {
                case 2:
                    Frm1_c.vol_ch2 = new float[] { ret_val[0], ret_val[1] };
                    break;
                case 21:
                    Frm1_c.vol_ch21 = new float[] { ret_val[0], ret_val[1],ret_val[3] };
                    break;
                case 4:
                    Frm1_c.vol_ch4 = new float[] { ret_val[0], ret_val[1],ret_val[4],ret_val[5] };
                    break;
                case 5:
                    Frm1_c.vol_ch5 = new float[] { ret_val[0], ret_val[1], ret_val[2], ret_val[4], ret_val[5] };
                    break;
                case 51:
                    Frm1_c.vol_ch51 = new float[] { ret_val[0], ret_val[1], ret_val[2], ret_val[3], ret_val[4], ret_val[5] };
                    break;
            }
            if (xa_mus != null) { xa_mus.Vol_change(0); }
            return;
        }
        private void Hsb_fc_ValueChanged(object sender, EventArgs e)
        {
            lab_fc.Text = ((float)Hsb_fc.Value / 10f).ToString();
        }

        private void Hsb_fl_ValueChanged(object sender, EventArgs e)
        {
            lab_fl.Text = ((float)Hsb_fl.Value / 10f).ToString();
        }

        private void Hsb_fr_ValueChanged(object sender, EventArgs e)
        {
            lab_fr.Text = ((float)Hsb_fr.Value / 10f).ToString();
        }

        private void Hsb_sub_ValueChanged(object sender, EventArgs e)
        {
            lab_sub.Text = ((float)Hsb_sub.Value / 10f).ToString();
        }

        private void Hsb_bl_ValueChanged(object sender, EventArgs e)
        {
            lab_bl.Text = ((float)Hsb_bl.Value / 10f).ToString();
        }

        private void Hsb_br_ValueChanged(object sender, EventArgs e)
        {
            lab_br.Text = ((float)Hsb_br.Value / 10f).ToString();
        }

        private void Hsb_Master_ValueChanged(object sender, EventArgs e)
        {
           lab_mas.Text = ((float)Hsb_Master.Value / 10f).ToString();
        }

        private void But_vol_Click(object sender, EventArgs e)
        {
            Set_array_vol(Frm1_c.ch);
        }

        private void But_exit_Click(object sender, EventArgs e)
        {
            Frm1_c.mus_exit = true;
            this.Close();
        }

        private void Lb_mus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Frm1_c.lock_list) { return; }
            Frm1_c.lock_list = true;
            lb_mus.Enabled = false;
            Application.DoEvents();
            Frm1_c.mus_exit = false;
            int x = lb_mus.SelectedIndex;
            for (; ; )
            {
                for (int i = x; i < Frm1_c.files.Length; i++)
                {
                    int y = Play_start(Frm1_c.files[i]);
                    switch (y)
                    {
                        case 0:
                            while (true)
                            {
                                if (Frm1_c.mus_exit) { Waittsk.Wait(); Waittsk.Dispose(); Frm1_c.lock_list = false; return; }
                                if (!xa_mus.mus_start[0]) { Waittsk.Wait(); Waittsk.Dispose(); break; }
                                Application.DoEvents();
                                System.Threading.Thread.Sleep(100);
                            }
                            break;
                        case -2:
                            break;
                        case -1:
                            lb_mus.Enabled = true;
                            Set_gb1(true);
                            Frm1_c.lock_list = false;
                            return;
                    }
                    try { lb_mus.SelectedIndex++; }
                    catch (Exception) { lb_mus.SelectedIndex = 0; }
                    Application.DoEvents();
                    Task.Run(() => { GC.Collect(); });
                    System.Threading.Thread.Sleep(100);
                }
                if (!cb_loop.Checked) { break; }
                x = 0;
            }
            lb_mus.Enabled = true;
            Set_gb1(true);
            Task.Run(() => { GC.Collect(); });
            Frm1_c.lock_list = false;
        }
        private void Set_gb1(bool swi)
        {
            gb_decord.Enabled = swi;
            gb_speakers.Enabled = swi;
            cb_bsidrev.Enabled = swi;
        }
        private void But_Licence_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Frm1_c.licence);
        }

        private void Rb_stereo_CheckedChanged(object sender, EventArgs e)
        {
            cb_bsidrev.Checked = true;
        }

        private void Rb_surround_CheckedChanged(object sender, EventArgs e)
        {
            cb_bsidrev.Checked = false;
        }
    }
    public static class Frm1_c
    {
        public const string licence = title+"\r\n"+version+"\r\n"+create+"\r\n\r\n\r\n"
                                    + "Licence(Ms-PL)\r\n\r\n"
                                    + "NAudio\r\n-Mark Heath\r\n"
                                    + "NAudio Vorbis\r\n-Andrew Ward\r\n"
                                    + "NAudio Wma\r\n-Mark Heath, Yuval Naveh\r\n"
                                    + "https://github.com/naudio\r\n\r\n"
                                    + "NVorbis\r\n-Andrew Ward\r\nhttp://nvorbis.codeplex.com/\r\n\r\n"
                                    + "NAudio.Flac\r\n-Nathan Harrenstein\r\nhttps://github.com/nharren\r\n"
                                    + " based on the sources of \"CSCore\"\r\n\r\n CSCore\r\n -Florian R.\r\n https://github.com/filoe/\r\n\r\n\r\n"
                                    + "Licence(Free?)\r\n\r\n"
                                    + "SharpDX\r\n-Alexandre Mutel\r\nhttp://sharpdx.org/";
        public const string title = "Audio Player たいたんぱー";
        public const string version = "Ver 170921-2";
        public const string create = "by under_binary(oya_bin)";
        public const string fullname = title + " /" + version + " /" + create;
        public static string[] files = null;
        public static bool lock_list = false;
        public static byte ch = 2;
        public static float vol_master = 0;
        public static bool mus_exit = false;
        public static float[] vol_ch2 = new float[] { 0, 0 };
        public static float[] vol_ch21 = new float[] { 0, 0, 0 };
        public static float[] vol_ch4 = new float[] { 0, 0, 0, 0 };
        public static float[] vol_ch5 = new float[] { 0, 0, 0, 0, 0 };
        public static float[] vol_ch51 = new float[] { 0, 0, 0, 0, 0, 0 };
    }
}
