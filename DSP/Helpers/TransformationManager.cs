using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using Accord.Math;

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
                result.Add(new Complex(pointsReal[i].Y, pointsIm[i].Y));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform.DFT(resultArray, FourierTransform.Direction.Forward);

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

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateRDFT(List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                result.Add(new Complex(pointsReal[i].Y, pointsIm[i].Y));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform.DFT(resultArray, FourierTransform.Direction.Backward);

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
                result.Add(new Complex(pointsReal[i].Y, pointsIm[i].Y));
            }

            Complex[] resultArray = result.ToArray();

            FourierTransform.FFT(resultArray, FourierTransform.Direction.Forward);

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

        

    }

    
}
