using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSP.Signals
{
    public class SampledSignal : Signal
    {
        private List<ObservablePoint> sampledSignalPoints;

        public float MSE;
        public float SNR;
        public float PSNR;
        public float MD;

        private Func<float, float> func;

        public int sampleFrequency;

        public SampledSignal(float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, int sampleFrequency, Func<float, float> func, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, true)
        {
            sampledSignalPoints = new List<ObservablePoint>();

            this.func = func;
            this.sampleFrequency = sampleFrequency;

            Sample(ref sampledSignalPoints, pointsReal);

            List<ObservablePoint> allSampledPoints = new List<ObservablePoint>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                int index = sampledSignalPoints.FindIndex(x => x.X > pointsReal[i].X);

                if (index == -1)
                    index = sampledSignalPoints.Count - 1;
                else
                    index--;

                allSampledPoints.Add(new ObservablePoint(pointsReal[i].X, sampledSignalPoints[index].Y));

            }

            CalculateMSE(pointsReal, allSampledPoints);
            CalculateSNR(pointsReal, allSampledPoints);
            CalculatePSNR(pointsReal);
            CalculateMD(pointsReal, allSampledPoints);

            PointsReal = sampledSignalPoints;
        }

        private void Sample(ref List<ObservablePoint> sampledSignal, List<ObservablePoint> points)
        {
            if (func.Target.GetType() == typeof(Signal))
            {
                float difference = 1 / (float)sampleFrequency;


                for (float i = 0; i < points.Count * ((float)1 / f); i += difference)
                {

                    int index = points.FindIndex(x => x.X == i);

                    if (index == -1)
                    {
                        ObservablePoint closestPoint = points.Aggregate((x1, x2) => Math.Abs(x1.X - i) < Math.Abs(x2.X - i) ? x1 : x2);

                        index = points.IndexOf(closestPoint);
                    }

                    sampledSignal.Add(points[index]);

                }

                //sampledSignal.RemoveAt(sampledSignal.Count - 1);
            }
            else
            {

                for (int i = 0; i < (d * sampleFrequency); i++)
                {
                    float t = (float)Math.Round((float)i / sampleFrequency + t1, 3);

                    sampledSignal.Add(new ObservablePoint(t, func(t)));
                }
            }
        }

        private void CalculateMSE(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float value = 0;

            for (int i = 0; i < originalPoints.Count; i++)
            {
                value += (float)Math.Pow((originalPoints[i].Y - quantizedPoints[i].Y), 2);
            }

            MSE = value / originalPoints.Count;
        }

        private void CalculateSNR(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float nom = 0;
            float denom = 0;

            for (int i = 0; i < originalPoints.Count; i++)
            {
                nom += (float)Math.Pow(originalPoints[i].Y, 2);
                denom += (float)Math.Pow(originalPoints[i].Y - quantizedPoints[i].Y, 2);
            }

            SNR = (float)(10 * Math.Log10(nom / denom));
        }

        private void CalculatePSNR(List<ObservablePoint> originalPoints)
        {
            float max = (float)originalPoints.Max(x => x.Y);

            PSNR = (float)(10 * Math.Log10(max / MSE));
        }

        private void CalculateMD(List<ObservablePoint> originalPoints, List<ObservablePoint> quantizedPoints)
        {
            float max = (float)Math.Abs(originalPoints[0].Y - quantizedPoints[0].Y);

            for (int i = 1; i < originalPoints.Count; i++)
            {
                float newMax = (float)Math.Abs(originalPoints[i].Y - quantizedPoints[i].Y);

                if (newMax > max)
                    max = newMax;
            }

            MD = max;
        }
    }
}
