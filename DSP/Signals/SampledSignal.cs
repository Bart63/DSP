using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSP.Signals
{
    public class SampledSignal : Signal
    {
        private List<ObservablePoint> sampledSignalPoints;

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

            MSE = CalculateMSE(pointsReal, allSampledPoints);
            SNR = CalculateSNR(pointsReal, allSampledPoints);
            PSNR = CalculatePSNR(pointsReal);
            MD = CalculateMD(pointsReal, allSampledPoints);

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

        
    }
}
