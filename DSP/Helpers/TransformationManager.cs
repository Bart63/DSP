using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace DSP.Helpers
{
    public static class TransformationManager
    {
        private static Action<float> getPercentOfCompletionCallback;

        public static void SetCallback(Action<float> callback)
        {
            getPercentOfCompletionCallback = callback;
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateDFT(List<ObservablePoint> points)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            Complex imaginaryUnit = new Complex(0, 1);

            stopwatch.Start();
            for (int i = 0; i < points.Count; i++)
            {
                Complex value = 0;

                for (int j = 0; j < points.Count; j++)
                {
                    value += points[j].Y * Complex.Pow(Math.E, -2 * imaginaryUnit * i * j * Math.PI / points.Count);
                }

                resultReal.Add(new ObservablePoint(points[i].X, value.Real));
                resultImaginary.Add(new ObservablePoint(points[i].X, value.Imaginary));

                if (getPercentOfCompletionCallback != null)
                {
                    getPercentOfCompletionCallback((float)Math.Round((double)i * 100 / points.Count));
                }
            }
            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }


        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateFFT(List<ObservablePoint> points)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            Complex imaginaryUnit = new Complex(0, 1);

            stopwatch.Start();


            var pairs = points.Select((x, i) => new Tuple<double, double, int>(x.X, x.Y, ReverseIndex(i)));

            points = (pairs.OrderBy(x => x.Item3).Select(x => new ObservablePoint(x.Item1, x.Item2))).ToList();
            
            //TODO: rest of algorithm 
            
            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        private static int ReverseIndex(int index1)
        {
            Byte[] index1Bytes = BitConverter.GetBytes(index1);
           
            index1Bytes.Reverse();
           
            int newIndex1 = BitConverter.ToInt16(index1Bytes, 0);

            return newIndex1;
        }

    }

    
}
