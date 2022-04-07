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
        public List<ObservablePoint> quantizedSignalPoints;

        public float MSE;
        public float SNR;
        public float PSNR;
        public float MD;

        public int k;
        
        public QuantizedSignal(float a, float t1, float d, float t, int f, bool isContinuous,
            List<ObservablePoint> pointsReal, int k, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, true)
        {
            quantizedSignalPoints = new List<ObservablePoint>();

            this.k = k;
            Quantize(pointsReal, ref quantizedSignalPoints);

            PointsReal = quantizedSignalPoints;
        }

        private void Quantize(List<ObservablePoint> points, ref List<ObservablePoint> quantizedSignal)
        {
            int difference = (int)Math.Round((float)points.Count(x => x.X < t1 + T) / k);


            for (int i = 0; i < points.Count; i += difference)
            {
                if (i + difference < points.Count)
                    quantizedSignal.AddRange(points.GetRange(i, difference).Select(delegate (ObservablePoint point)
                    {
                        return new ObservablePoint(point.X, points[i].Y);
                    }));

            }
        }

        public override List<ObservablePoint> GetRealPointsToChart()
        {
            
            List<ObservablePoint> newPoints = new List<ObservablePoint>();

            
            newPoints.Add(quantizedSignalPoints[0]);

            for (int i = 1; i < quantizedSignalPoints.Count - 1; i++)
            {
                if (quantizedSignalPoints[i-1].Y != quantizedSignalPoints[i].Y &&
                    quantizedSignalPoints[i].Y == quantizedSignalPoints[i + 1].Y)
                {
                    newPoints.Add(quantizedSignalPoints[i]);
                }
            }

            newPoints.Add(quantizedSignalPoints.Last());

            return newPoints;
           
        }
        
    }
}
