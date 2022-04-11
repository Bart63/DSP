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

            MSE = CalculateMSE(pointsReal, allQuantizedPoints);
            SNR = CalculateSNR(pointsReal, allQuantizedPoints);
            PSNR = CalculatePSNR(pointsReal);
            MD= CalculateMD(pointsReal, allQuantizedPoints);

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

            //quantizedSignal.RemoveAt(quantizedSignal.Count - 1);
            
        }

        
        
    }
}
