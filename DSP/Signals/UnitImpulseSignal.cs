using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Signals
{
    public class UnitImpulseSignal : Signal
    {
        public int ns;
        public int n1;
        public int l;


        public UnitImpulseSignal(float a, int n1, int l, int f, int ns) : base(a, 0, 0, 0, f, false)
        {
            this.ns = ns;
            this.n1 = n1;
            this.l = l;

            GeneratePoints(isContinuous);
        }

        public override void GeneratePoints(bool isContinuous, Action resetValuesCallback = null)
        {
            
            for (int i = n1; i < (l + n1); i++)
            {
                if (i != ns)
                    PointsReal.Add(new ObservablePoint((float)i/f, 0));
                else
                    PointsReal.Add(new ObservablePoint((float)i/f, A));
            }


            CalculateAverageSignalAbsValue(isContinuous);
            CalculateAverageSignalValue(isContinuous);
            CalculateAverageSignalPower(isContinuous);
            CalculateVariance(isContinuous);
            CalculateEffectiveValue();
        }
    }
}
