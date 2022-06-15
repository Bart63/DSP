using DSP.Signals;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP.Helpers
{
    public static class FileManager
    {
        public static void Save(Signal signal, bool isComplex = false)
        {
            List<byte> binary = new List<byte>();

            string text = "";

            binary.AddRange(BitConverter.GetBytes(signal.t1)); //4 bytes
            text += signal.t1.ToString("00.##") + " || ";

            binary.AddRange(BitConverter.GetBytes(signal.f)); //4 bytes
            text += signal.f.ToString() + " || ";

            binary.AddRange(BitConverter.GetBytes(signal.T)); //4 bytes
            text += signal.T.ToString() + " || ";

            binary.AddRange(BitConverter.GetBytes(isComplex)); //1 byte
            text += isComplex.ToString() + " || ";

            binary.AddRange(BitConverter.GetBytes(signal.isContinuous)); //1 byte
            text += signal.isContinuous.ToString() + " || ";

            binary.AddRange((!isComplex)? BitConverter.GetBytes(signal.PointsReal.Count)
                : BitConverter.GetBytes(signal.PointsReal.Count * 2)); //4 bytes

            text += (!isComplex) ? signal.PointsReal.Count.ToString() : (signal.PointsReal.Count * 2).ToString();
            text += "\n";

            foreach (var p in signal.PointsReal)
            {
                binary.AddRange(BitConverter.GetBytes((float)p.Y)); // 4 bytes

                text += p.Y.ToString("00.##") + "\n";
            }

            if (isComplex)
            {
                foreach (var p in signal.PointsIm)
                {
                    binary.AddRange(BitConverter.GetBytes((float)p.Y)); // 4 bytes

                    text += p.Y.ToString("00.##") + "\n";
                }
            }

            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "binary files (*.bin)|*.bin";
            fileDialog.FilterIndex = 0;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(fileDialog.FileName, binary.ToArray());
                File.WriteAllText(fileDialog.FileName + ".txt", text);
            }
        }

        public static Signal Load()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "binary files (*.bin)|*.bin";
            fileDialog.FilterIndex = 0;
            fileDialog.RestoreDirectory = true;

            List<byte> binary = new List<byte>();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                binary.AddRange(File.ReadAllBytes(fileDialog.FileName));

                float t1 = BitConverter.ToSingle(binary.GetRange(0, 4).ToArray(), 0);

                int f = BitConverter.ToInt32(binary.GetRange(4, 4).ToArray(), 0);

                float T = BitConverter.ToSingle(binary.GetRange(8, 4).ToArray(), 0);

                bool isComplex = BitConverter.ToBoolean(new byte[] { binary[12] }, 0);
                
                bool isContinuous = BitConverter.ToBoolean(new byte[] { binary[13] }, 0);

                int n = BitConverter.ToInt32(binary.GetRange(14, 4).ToArray(), 0);

                float d = (float)n / f;


                List<ObservablePoint> pointsReal = new List<ObservablePoint>();
                List<ObservablePoint> pointsIm = new List<ObservablePoint>();

                for (int i = 0; i < (d * f); i++)
                {
                    float t = (float)i / f + t1;


                    pointsReal.Add(new ObservablePoint(t, (float)BitConverter.ToSingle(binary.GetRange(i * 4 + 14, 4).ToArray(), 0)));
                }

                if (isComplex)
                {
                    
                    for (int i = 0; i < (d * f); i++)
                    {
                        float t = (float)i / f + t1;


                        pointsIm.Add(new ObservablePoint(t, (float)BitConverter.ToSingle(binary.GetRange(i * 4 + 14 + (pointsReal.Count * 4), 4).ToArray(), 0)));
                    }

                }
                

                Signal signal = new Signal((float)pointsReal.Max(x => x.Y), t1, d, T, f, isContinuous, pointsReal, pointsIm, Signal.SignalType.original);

                return signal;
            }
            else
                return null;
        }
    }
}
