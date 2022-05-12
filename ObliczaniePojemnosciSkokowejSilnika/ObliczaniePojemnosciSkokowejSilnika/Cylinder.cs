using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliczaniePojemnosciSkokowejSilnika.Cylinders
{
    internal class Cylinder
    {
       
        private double d;
        private double s;
        public Cylinder(double d, double s)
        {
            this.d = d;
            this.s = s;
        }

        public double GetVolumeCylinder()
        { 
            return Math.PI / 4 * Math.Pow(d, 2) * s;
        }


    }
}
