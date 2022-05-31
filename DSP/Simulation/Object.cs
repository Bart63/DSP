using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.Simulation
{
    public class Object
    {
        public float speed { get; set; }    
        public float time { get; set; } = 0;    
        public float x { get; set; } = 0;

        public void updateX ()
        {
            x = speed * time;
        }

        public void updateTime(float t)
        {
            time += t;
        }
    }
}
