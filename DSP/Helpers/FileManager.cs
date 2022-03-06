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

            binary.AddRange(BitConverter.GetBytes(isComplex)); //1 byte
            text += isComplex.ToString() + " || ";

            binary.AddRange(BitConverter.GetBytes(signal.isContinuous)); //1 byte
            text += signal.isContinuous.ToString() + " || ";

            binary.AddRange((!isComplex)? BitConverter.GetBytes(signal.PointsReal.Count)
                : BitConverter.GetBytes(signal.PointsReal.Count * 2)); //4 bytes

            text += (!isComplex) ? signal.PointsReal.Count.ToString() : (signal.PointsReal.Count * 2).ToString();
            text += "\n";

            if (!isComplex)
            {
                foreach (var p in signal.PointsReal)
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

                bool isComplex = BitConverter.ToBoolean(new byte[] { binary[8] }, 0);
                
                bool isContinuous = BitConverter.ToBoolean(new byte[] { binary[9] }, 0);

                int n = BitConverter.ToInt32(binary.GetRange(10, 4).ToArray(), 0);

                

                List<ObservablePoint> pointsReal = new List<ObservablePoint>();
                List<ObservablePoint> pointsIm = new List<ObservablePoint>();

                float t = t1;

                if (!isComplex)
                {
                    for (int i = 14; i < n * 4; i += 4)
                    {
                        float value = (float)BitConverter.ToSingle(binary.GetRange(i, 4).ToArray(), 0);

                        pointsReal.Add(new ObservablePoint(t, value));

                        t += 1 / (float)f;
                    }
                }
                else
                {
                    return null;
                }

                Signal signal = new Signal((float)pointsReal.Max(x => x.Y), t1, t, 0, f, isContinuous, pointsReal);

                return signal;
            }
            else
                return null;
        }
    }
}
