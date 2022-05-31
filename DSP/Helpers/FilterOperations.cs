using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Helpers
{
    public static class FilterOperations
    {
        public static List<float> GenerateFilter(int f, int M, int f0, int htype, int windowType)
        {
            int K = (int)Math.Round((decimal)(f / f0));

            if (M % 2 == 0)
                M++;
            
            List<float> coefficients = new List<float>();

            for (int i = 0; i < M; i++)
            {
                coefficients.Add(GetH(htype, M, i, K));
            }

            return (windowType == 0) ? coefficients : getBlackmanWindowCoefs(coefficients, M);
        }


        public static float GetH(int type, int M, int n, int K)
        {
            switch(type)
            {
                case 0:

                    if (n == (M - 1) / 2)
                        return 2 / (float)K;
                    else
                    {
                        int center = (M - 1) / 2;
                        return (float)(Math.Sin(Math.PI * 2 * (n - center) / K) / (Math.PI * (n - center)));
                    }

                case 1:

                    float value;

                    if (n == (M - 1) / 2)
                        value = 2 / (float)K;
                    else
                    {
                        int center = (M - 1) / 2;
                        value = (float)(Math.Sin(Math.PI * 2 * (n - center) / K) / (Math.PI * (n - center)));
                    }

                    value *= (float)(2 * Math.Sin(Math.PI * n / 2.0));
                    return value;

            }
            return 0;
        }

        private static List<float> getBlackmanWindowCoefs(List<float> coefficients, int M)
        {
            List<float> result = new List<float>();

            for (int i = 0; i < coefficients.Count; i++)
            {
                float factor = (float)(0.42 - (0.5 * Math.Cos(2 * Math.PI * i / M)) + (0.08 * Math.Cos(4 * Math.PI * i / M)));
                result.Add(factor * coefficients[i]);
            }

            return result;
        }


    }
}
