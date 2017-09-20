using SharpDX.IO;
using SharpDX.Multimedia;
using SharpDX.XAudio2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_01
{
    class Xa2_mus
    {
        static SharpDX.XAudio2.XAudio2 xa_sou = null;
        static List<SharpDX.XAudio2.SourceVoice> xa_voi = new List<SourceVoice>();

        public void Dispose()
        {
            for (int i = xa_voi.Count - 1; i >= 0; i--)
            {
                try { xa_voi[i].StreamEnd -= new SourceVoice.VoidAction(End_buffer); }
                catch (Exception) { }
                try { xa_voi[i].Stop(); }
                catch (Exception) { }
                try { ms_str[i].Close(); }
                catch (Exception) { }
                try { xa_voi[i].Dispose(); }
                catch (Exception) { }
                try { ms_str[i].Dispose(); }
                catch (Exception) { }
                mus_start[i] = false;
            }
            try { xa_sou.Dispose(); }
            catch (Exception) { }
            xa_voi.Clear();
            mas_vol.Clear();
            mas_wav.Clear();
            wav_ch.Clear();
            wav_lop.Clear();
            wav_lop_n.Clear();
            ms_str.Clear();
        }
        //static int dev_ind = 0;
        public void Init(int dev,int ch)
        {
            xa_sou = new SharpDX.XAudio2.XAudio2(SharpDX.XAudio2.XAudio2Version.Version27);
            //if (dev >= xa_sou.DeviceCount)
            //{ MessageBox.Show("device_max:" + (xa_sou.DeviceCount - 1).ToString() + " select is:"
            //    + dev + "\r\nError Restart device 0"); dev_ind = 0; }
            //else { dev_ind = dev; }
            switch (ch)
            {
                case 21:
                    ch = 3;
                    break;
                case 51:
                    ch = 6;
                    break;
            }
            //var xa_mas = new SharpDX.XAudio2.MasteringVoice(xa_sou, ch, 48000, dev_ind);
            var xa_mas = new SharpDX.XAudio2.MasteringVoice(xa_sou,ch,48000);
            //dev_ind = dev;
            xa_mas.Dispose();
            mus_start.Clear();
        }
        static List<float> mas_vol = new List<float>();
        static List<byte[]> mas_wav = new List<byte[]>();
        static List<byte> wav_ch = new List<byte>();
        static List<bool> wav_lop = new List<bool>();
        static List<byte> wav_lop_n = new List<byte>();
        static List<SharpDX.DataStream> ms_str = new List<SharpDX.DataStream>();
        public List<bool> mus_start = new List<bool>();
        public void Step1(byte[] waveData, bool loop, float vol, byte ch)
        {
            mas_vol.Add(vol);
            wav_ch.Add(ch);
            mas_wav.Add(waveData);
            wav_lop.Add(loop);
            if (loop) { wav_lop_n.Add((byte)(wav_lop.Count - 1)); }
            mus_start.Add(false);
            xa_voi.Add(null);
            ms_str.Add(null);
        }
        private int Step2(int track, byte[] waveData, bool loop, byte ch)
        {
            try
            {
                if (xa_voi[track] != null) { xa_voi[track].Stop(); ms_str[track].Close(); }
                // ms_str can't dispose
                ms_str[track] = new SharpDX.DataStream(waveData.Length, true, true);
                var soundstream = new SharpDX.DataStream(ms_str[track]);
                var buffer = new AudioBuffer
                {
                    Stream = soundstream,
                    AudioBytes = waveData.Length,
                    Flags = BufferFlags.EndOfStream,
                    LoopCount = 0
                };
                buffer.Stream.Write(waveData, 0, waveData.Length);
                WaveFormatExtensible waveFormat = null;
                try
                {
                    switch (ch)
                    {
                        case 2:
                            waveFormat = new WaveFormatExtensible(48000, 16, 2)
                            { ChannelMask = Speakers.Stereo };
                            break;
                        case 21:
                            waveFormat = new WaveFormatExtensible(48000, 16, 3)
                            { ChannelMask = Speakers.TwoPointOne };
                            break;
                        case 4:
                            waveFormat = new WaveFormatExtensible(48000, 16, 4)
                            { ChannelMask = Speakers.Quad };
                            break;
                        case 5:
                            waveFormat = new WaveFormatExtensible(48000, 16, 5)
                            { ChannelMask = Speakers.Quad | Speakers.FrontCenter };
                            break;
                        case 51:
                            waveFormat = new WaveFormatExtensible(48000, 16, 6)
                            { ChannelMask = Speakers.FivePointOne };
                            break;
                    }
                    xa_voi[track] = new SourceVoice(xa_sou, waveFormat, true);
                }
                catch (Exception) { return -1; }
                xa_voi[track].SubmitSourceBuffer(buffer, null);
            }
            catch (Exception) { return -2; }
            return 0;
        }
        private void End_buffer()
        {
            for (int i = 0; i < wav_lop.Count; i++)
            {
                if (wav_lop[i] && xa_voi[i].State.BuffersQueued == 0) { Play_exe(i); return; }
                mus_start[i] = false;
            }
        }
        private void End_buffer_org()
        {
            for (int i = 0; i < wav_lop_n.Count; i++)
            {
                if (xa_voi[wav_lop_n[i]].State.BuffersQueued == 0) { Play_exe(wav_lop_n[i]); return; }
            }
        }
        public int Play_exe(int track)
        {
            try
            {
                //dispo_true[track] = true;
                if(Step2(track, mas_wav[track], wav_lop[track], wav_ch[track])==-1)
                { return - 1; }
                xa_voi[track].StreamEnd += new SourceVoice.VoidAction(End_buffer);
                Vol_change(track);
                mus_start[track] = true;
                xa_voi[track].Start();
                //dispo_true[track] = false;
            }
            catch (Exception) { }
            return 0;
        }
        public void Vol_change(int track)
        {
            try
            {
                float[] p_vol = Set_vol_para(wav_ch[track]);
                for (int i = 0; i < p_vol.Length; i++)
                {
                    p_vol[i] = p_vol[i] * Frm1_c.vol_master;
                    if (p_vol[i] > 1) { p_vol[i] = 1; }
                    else if (p_vol[i] < 0) { p_vol[i] = 0; }
                }
                for (int i = 0; i < p_vol.Length; i++)
                { xa_voi[track].SetChannelVolumes(i, p_vol); }
            }
            catch (Exception) { }
        }   
        private float[] Set_vol_nor(int track)
        {
            switch (wav_ch[track])
            {
                case 2:
                    return new float[] { mas_vol[track], mas_vol[track] };
                case 21:
                    return new float[] { mas_vol[track], mas_vol[track], mas_vol[track] };
                case 4:
                    return new float[] { mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track] };
                case 5:
                    return new float[] { mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track] };
                case 51:
                    return new float[] { mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track], mas_vol[track] };
            }
            return new float[2];
        }
        private float[] Set_vol_para(int ch)
        {
            switch (ch)
            {
                case 2:
                    return Frm1_c.vol_ch2;
                case 21:
                    return Frm1_c.vol_ch21;
                case 4:
                    return Frm1_c.vol_ch4;
                case 5:
                    return Frm1_c.vol_ch5;
                case 51:
                    return Frm1_c.vol_ch51;
            }
            return new float[2];
        }
    }
}

