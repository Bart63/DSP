using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Helpers
{
    public static class FilterOperations
    {
        public static List<float> GenerateLowPassFilter(int f, int M, int f0, int type)
        {
            int K = (int)Math.Round((decimal)(f / f0));

            if (M % 2 == 0)
                M++;
            
            List<float> coefficients = new List<float>();

            for (int i = 0; i < M; i++)
            {
                coefficients.Add(GetH(type, M, i, K));
            }

            return coefficients;
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

            }
            return 0;
        }

        

    }
}
