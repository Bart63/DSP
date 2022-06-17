using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using Accord.Math;
using Accord.Math.Transforms;

namespace DSP.Helpers
{
    public static class TransformationManager
    {
        private static Action<float> getPercentOfCompletionCallback;

        public static void SetCallback(Action<float> callback)
        {
            getPercentOfCompletionCallback = callback;
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateDFT(List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                double imValue = (pointsIm.Count != 0) ? pointsIm[i].Y : 0;

                result.Add(new Complex(pointsReal[i].Y, imValue));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform2.DFT(resultArray, FourierTransform.Direction.Forward);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Real));
                resultImaginary.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Imaginary));
            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateIDFT(List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                double imValue = (pointsIm.Count != 0) ? pointsIm[i].Y : 0;

                result.Add(new Complex(pointsReal[i].Y, imValue));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform2.DFT(resultArray, FourierTransform.Direction.Backward);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Real));
                resultImaginary.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Imaginary));
            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateFFT(List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                double imValue = (pointsIm.Count != 0) ? pointsIm[i].Y : 0;

                result.Add(new Complex(pointsReal[i].Y, imValue));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform2.FFT(resultArray, FourierTransform.Direction.Forward);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Real));
                resultImaginary.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Imaginary));
            }
            
            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateIFFT(List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                double imValue = (pointsIm.Count != 0) ? pointsIm[i].Y : 0;

                result.Add(new Complex(pointsReal[i].Y, imValue));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform2.FFT(resultArray, FourierTransform.Direction.Backward);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Real));
                resultImaginary.Add(new ObservablePoint(pointsReal[i].X, resultArray[i].Imaginary));
            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateDCTII(List<ObservablePoint> pointsReal)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            double[] resultArray = pointsReal.Select(x => x.Y).ToArray();

            CosineTransform.DCT(resultArray);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i]));

            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateIDCTII(List<ObservablePoint> pointsReal)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            double[] resultArray = pointsReal.Select(x => x.Y).ToArray();

            CosineTransform.IDCT(resultArray);

            for (int i = 0; i < pointsReal.Count; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, resultArray[i]));

            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }
    }

    
}
