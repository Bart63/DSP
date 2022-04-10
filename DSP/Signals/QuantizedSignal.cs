using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class QuantizedSignal : Signal
    {
        private List<ObservablePoint> quantizedSignalPoints;

        public float MSE;
        public float SNR;
        public float PSNR;
        public float MD;

        public int quantizationLevels;
        
        public QuantizedSignal(float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, int quantizationLevels, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, true)
        {
            quantizedSignalPoints = new List<ObservablePoint>();

            this.quantizationLevels = quantizationLevels;
            Quantize(pointsReal, ref quantizedSignalPoints);

            List<ObservablePoint> allQuantizedPoints = new List<ObservablePoint>();

            for (int i = 0; i < pointsReal.Count; i++)
            {
                int index = quantizedSignalPoints.FindIndex(x => x.X > pointsReal[i].X);

                if (index == -1)
                    index = quantizedSignalPoints.Count - 1;
                else
                    index--;

                allQuantizedPoints.Add(new ObservablePoint(pointsReal[i].X, quantizedSignalPoints[index].Y));

            }

            CalculateMSE(pointsReal, allQuantizedPoints);
            CalculateSNR(pointsReal, allQuantizedPoints);
            CalculatePSNR(pointsReal);
            CalculateMD(pointsReal, allQuantizedPoints);

            PointsReal = quantizedSignalPoints;
        }

        private void Quantize(List<ObservablePoint> points, ref List<ObservablePoint> quantizedSignal)
        {
            float difference = 1 / (float)quantizationLevels;


            for (float i = 0; i < points.Count * ((float)1/f); i += difference)
            {
                
                int index = points.FindIndex(x => x.X == i);

                if (index == -1)
                {
                    ObservablePoint closestPoint = points.Aggregate((x1, x2) => Math.Abs(x1.X - i) < Math.Abs(x2.X - i) ? x1 : x2);

                    index = points.IndexOf(closestPoint);
                }

                quantizedSignal.Add(points[index]);

            }

            quantizedSignal.RemoveAt(quantizedSignal.Count - 1);
            
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
