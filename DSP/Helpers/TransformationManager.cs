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

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateFCT(List<ObservablePoint> pointsReal)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            int length = pointsReal.Count;
            int halfLength = pointsReal.Count / 2;

            Complex[] temp = new Complex[length];

            for (int i = 0; i < halfLength; i++)
            {
                temp[i] = pointsReal[i * 2].Y;
                temp[length - 1 - i] = pointsReal[i * 2 + 1].Y;
            }

            if (length % 2 == 1)
            {
                temp[halfLength] = pointsReal[length - 1].Y;
            }

            List<ObservablePoint> nearlyDoneReal = temp.Select(x => new ObservablePoint(0, x.Real)).ToList();
            List<ObservablePoint> nearlyDoneIm = temp.Select(x => new ObservablePoint(0, x.Imaginary)).ToList();

            var fft = await calculateFFT(nearlyDoneReal, nearlyDoneIm);

            nearlyDoneReal = fft.resultReal;
            nearlyDoneIm = fft.resultIm;

            for (int i = 0; i < nearlyDoneReal.Count; i++)
            {
                temp[i] = new Complex(nearlyDoneReal[i].Y, nearlyDoneIm[i].Y);

                resultReal.Add(new ObservablePoint(pointsReal[i].X, (temp[i] * Complex.Exp(
                    new Complex(0, -i * Math.PI / (length * 2)))).Real));
            }


            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }

        public static async Task<(List<ObservablePoint> resultReal, List<ObservablePoint> resultIm, float time)> calculateIFCT(List<ObservablePoint> pointsReal)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            List<ObservablePoint> resultReal = new List<ObservablePoint>();
            List<ObservablePoint> resultImaginary = new List<ObservablePoint>();

            int length = pointsReal.Count;
            int halfLength = pointsReal.Count / 2;

            if (length > 0)
            {
                pointsReal[0].Y /= 2;
            }

            Complex[] temp = new Complex[length];

            for (int i = 0; i < length; i++)
            {
                temp[i] = pointsReal[i].Y * Complex.Exp(new Complex(0, -i * Math.PI / (length * 2)));
            }

            List<ObservablePoint> nearlyDoneReal = temp.Select(x => new ObservablePoint(0, x.Real)).ToList();
            List<ObservablePoint> nearlyDoneIm = temp.Select(x => new ObservablePoint(0, x.Imaginary)).ToList();

            var fft = await calculateFFT(nearlyDoneReal, nearlyDoneIm);

            nearlyDoneReal = fft.resultReal;

            double[] almost = new double[nearlyDoneReal.Count];

            for (int i = 0; i < halfLength; i++)
            {
                almost[i * 2] = nearlyDoneReal[i].Y;
                almost[i * 2 + 1] = nearlyDoneReal[length - 1 - i].Y;
            }

            if (length % 2 == 1)
            {
                almost[length - 1] = nearlyDoneReal[halfLength].Y;
            }

            for (int i = 0; i < length; i++)
            {
                resultReal.Add(new ObservablePoint(pointsReal[i].X, almost[i]));
            }

            stopwatch.Stop();

            TimeSpan span = stopwatch.Elapsed;

            float time = (span.Seconds * 1000) + span.Milliseconds;

            return (resultReal, resultImaginary, time);
        }
    }

    
}
