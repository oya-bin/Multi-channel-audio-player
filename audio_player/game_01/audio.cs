﻿using NAudio.Wave;
using SharpDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_01
{
    class Audio
    {
        public static byte[] Binary_read(string fil_n)
        {
            List<byte> buf = new List<byte>(); // データ格納用配列
            try
            {
                FileStream fs = new FileStream(fil_n, FileMode.Open, FileAccess.Read);
                int fileSize = (int)fs.Length; // ファイルのサイズ
                BinaryReader bl = new BinaryReader(fs);
                for (int i = 0; i < 44; i++)
                { bl.ReadByte(); }
                for (int i = 44; i < fileSize; i++)
                { buf.Add(bl.ReadByte()); }
                bl.Dispose();
                fs.Dispose();
            }
            catch (Exception) { }
            return buf.ToArray();
        }
        public static byte[] Wma_to_wav(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                NAudio.WindowsMediaFormat.WMAFileReader reader = new NAudio.WindowsMediaFormat.WMAFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                NAudio.WindowsMediaFormat.WMAFileReader reader = new NAudio.WindowsMediaFormat.WMAFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        public static byte[] Wav_to_wav2(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                WaveFileReader reader = new WaveFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                WaveFileReader reader = new WaveFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        public static byte[] Mp3_to_wav(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                Mp3FileReader reader = new Mp3FileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                Mp3FileReader reader = new Mp3FileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        public static byte[] Aiff_to_wav(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                AiffFileReader reader = new AiffFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                AiffFileReader reader = new AiffFileReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        public static byte[] Flac_to_wav(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                NAudio.Flac.FlacReader reader = new NAudio.Flac.FlacReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                NAudio.Flac.FlacReader reader = new NAudio.Flac.FlacReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        public static byte[] Ogg_to_wav(string fil_n, byte ch, out byte[] mono)
        {
            WaveFormat format = new WaveFormat(48000, 16, 1);
            mono = null;
            try
            {
                NAudio.Vorbis.VorbisWaveReader reader = new NAudio.Vorbis.VorbisWaveReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    mono = new byte[stream.Length];
                    stream.Read(mono, 0, mono.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            format = new WaveFormat(48000, 16, ch);
            byte[] buffer = null;
            try
            {
                NAudio.Vorbis.VorbisWaveReader reader = new NAudio.Vorbis.VorbisWaveReader(fil_n);
                using (WaveFormatConversionStream stream = new WaveFormatConversionStream(format, reader))
                {
                    buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                }
                reader.Dispose();
            }
            catch (Exception) { }
            return buffer;
        }
        private static void Set_surround(ref byte[] byt1,ref byte[] byt2)
        {
            short srt1 = BitConverter.ToInt16(byt1, 0);
            short srt2 = BitConverter.ToInt16(byt2, 0);
            int in1 = (int)srt1 - (int)srt2;
            if (in1 < short.MinValue) { in1 = short.MinValue; }
            else if (in1 > short.MaxValue) { in1 = short.MaxValue; }
            int in2 = (int)srt2 - (int)srt1;
            if (in2 < short.MinValue) { in2 = short.MinValue; }
            else if (in2 > short.MaxValue) { in2 = short.MaxValue; }
            byt1 = BitConverter.GetBytes(in1);
            byt2 = BitConverter.GetBytes(in2);
        }
        public static byte[] Ch2_to_ch4(byte[] dat,bool rev,bool surround)
        {
            List<byte> byt = new List<byte>();
            int i2;
            for (int i=0;i<dat.Length;i+=4)
            {
                i2 = i + 2;
                byt.Add(dat[i]); byt.Add(dat[i + 1]);
                byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                if (rev)
                {
                    if (surround)
                    {
                        byte[] byt1 = new byte[] { dat[i2], dat[i2 + 1] };
                        byte[] byt2 = new byte[] { dat[i], dat[i + 1] };
                        Set_surround(ref byt1,ref byt2);
                        byt.Add(byt1[0]); byt.Add(byt1[1]);
                        byt.Add(byt2[0]); byt.Add(byt2[1]);
                    }
                    else
                    {
                        byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                        byt.Add(dat[i]); byt.Add(dat[i + 1]);
                    }
                }
                else
                {
                    if (surround)
                    {
                        byte[] byt1 = new byte[] { dat[i], dat[i + 1] };
                        byte[] byt2 = new byte[] { dat[i2], dat[i2 + 1] };
                        Set_surround(ref byt1, ref byt2);
                        byt.Add(byt1[0]); byt.Add(byt1[1]);
                        byt.Add(byt2[0]); byt.Add(byt2[1]);
                    }
                    else
                    {
                        byt.Add(dat[i]); byt.Add(dat[i + 1]);
                        byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                    }
                }
            }
            return byt.ToArray();
        }
        public static byte[] Ch2_to_ch21(byte[] dat, bool rev,byte[] mono)
        {
            List<byte> byt = new List<byte>();
            int i2;int i3;
            for (int i = 0; i < dat.Length; i += 4)
            {
                i2 = i + 2;
                i3 = i / 2;
                byt.Add(dat[i]); byt.Add(dat[i + 1]);
                byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                byt.Add(mono[i3]); byt.Add(mono[i3 + 1]);
            }
            return byt.ToArray();
        }
        public static byte[] Ch2_to_ch51(byte[] dat, bool rev, byte[] mono,bool surround)
        {
            List<byte> byt = new List<byte>();
            int i2; int i3;
            for (int i = 0; i < dat.Length; i += 4)
            {
                i2 = i + 2;
                i3 = i / 2;
                byt.Add(dat[i]); byt.Add(dat[i + 1]);
                byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                byt.Add(mono[i3]); byt.Add(mono[i3 + 1]);
                byt.Add(mono[i3]); byt.Add(mono[i3 + 1]);
                if (rev)
                {
                    if (surround)
                    {
                        byte[] byt1 = new byte[] { dat[i2], dat[i2 + 1] };
                        byte[] byt2 = new byte[] { dat[i], dat[i + 1] };
                        Set_surround(ref byt1, ref byt2);
                        byt.Add(byt1[0]); byt.Add(byt1[1]);
                        byt.Add(byt2[0]); byt.Add(byt2[1]);
                    }
                    else
                    {
                        byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                        byt.Add(dat[i]); byt.Add(dat[i + 1]);
                    }
                }
                else
                {
                    if (surround)
                    {
                        byte[] byt1 = new byte[] { dat[i], dat[i + 1] };
                        byte[] byt2 = new byte[] { dat[i2], dat[i2 + 1] };
                        Set_surround(ref byt1, ref byt2);
                        byt.Add(byt1[0]); byt.Add(byt1[1]);
                        byt.Add(byt2[0]); byt.Add(byt2[1]);
                    }
                    else
                    {
                        byt.Add(dat[i]); byt.Add(dat[i + 1]);
                        byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                    }
                }
            }
            return byt.ToArray();
        }
        public static byte[] Ch2_to_ch5(byte[] dat, bool rev, byte[] mono)
        {
            List<byte> byt = new List<byte>();
            int i2; int i3;
            for (int i = 0; i < dat.Length; i += 4)
            {
                i2 = i + 2;
                i3 = i / 2;
                byt.Add(dat[i]); byt.Add(dat[i + 1]);
                byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                byt.Add(mono[i3]); byt.Add(mono[i3 + 1]);
                if (rev)
                {
                    byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                    byt.Add(dat[i]); byt.Add(dat[i + 1]);
                }
                else
                {
                    byt.Add(dat[i]); byt.Add(dat[i + 1]);
                    byt.Add(dat[i2]); byt.Add(dat[i2 + 1]);
                }
            }
            return byt.ToArray();
        }
    }
}
