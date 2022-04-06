using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class ReconstructedSignal : Signal
    {
        public List<ObservablePoint> reconstructedSignalPointsReal;

        public ReconstructedSignal(float a, float t1, float d, float t, int f, bool isContinuous, int methodIndex, int rFrequency, List<ObservablePoint> pointsReal, List<ObservablePoint> pointsIm = null)
            : base(a, t1, d, t, f, isContinuous, pointsReal, pointsIm, false)
        {
            reconstructedSignalPointsReal = new List<ObservablePoint>();

            Reconstruct(methodIndex, ref reconstructedSignalPointsReal, PointsReal, rFrequency);
        }

        private void Reconstruct(int method, ref List<ObservablePoint> reconstructedSignal, List<ObservablePoint> points, int frequency)
        {
            switch(method)
            {
                case 1:



                    break;


                case 2:



                    break;
            }
        }
    }
}
