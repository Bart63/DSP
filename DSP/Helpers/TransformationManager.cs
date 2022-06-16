using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra;

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

            List<Complex> W1 = new List<Complex>();
            List<Complex> W = new List<Complex>();

            for (int i = 0; i < points.Count/2; i++)
            {
                W1.Add(Complex.Pow(Math.E, (imaginaryUnit * 2 * Math.PI) / points.Count));
                
            }

            W.AddRange(W1);

            List<Complex> pointsComplex = new List<Complex>();

            pointsComplex.AddRange(points.Select(x => new Complex(x.Y, 0)));

            List<Complex> result1 = new List<Complex>();
            List<Complex> result2 = new List<Complex>();

            for (int j = 1; j < points.Count; j *= 2)
            {
                result1.Clear();
                result2.Clear();

                for (int i = 0; i < points.Count / 2; i++)
                {
                    List<Complex> coeffs = new List<Complex>();
                    coeffs.Add(1);
                    coeffs.Add(Complex.Pow(W[i], -i));
                    coeffs.Add(1);
                    coeffs.Add(-Complex.Pow(W[i], -i));

                    List<Complex> X = new List<Complex>();
                    X.Add(pointsComplex[i]);
                    X.Add(0);
                    X.Add(pointsComplex[i + points.Count / 2]);
                    X.Add(0);

                    Matrix<Complex> matrixCoeffs = Matrix<Complex>.Build.DenseOfRowMajor(2, 2, coeffs);
                    Matrix<Complex> matrixX = Matrix<Complex>.Build.DenseOfRowMajor(2, 2, X);

                    Matrix<Complex> result = matrixCoeffs * matrixX;

                    result1.Add(result.At(0, 0));
                    result2.Add(result.At(0, 1));
                }

                pointsComplex = new List<Complex>();

                pointsComplex.AddRange(result1);
                pointsComplex.AddRange(result2);
            }

            List<Complex> finalComplexResult = new List<Complex>();

            finalComplexResult.AddRange(result1);
            finalComplexResult.AddRange(result2);

            for (int i = 0; i < points.Count; i++)
            {
                resultReal.Add(new ObservablePoint(points[i].X, finalComplexResult[i].Real));
                resultImaginary.Add(new ObservablePoint(points[i].X, finalComplexResult[i].Imaginary));
            }
            
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
