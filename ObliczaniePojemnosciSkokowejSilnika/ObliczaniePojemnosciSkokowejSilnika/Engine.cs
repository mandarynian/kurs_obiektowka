using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObliczaniePojemnosciSkokowejSilnika.Cylinders;

namespace ObliczaniePojemnosciSkokowejSilnika.Engines
{
    public class Engine
    {
        public string Name { get; set; }

        private Cylinder cylinder;
        private int cylindersCount;


        public Engine(string name, int cylindersCount, double d, double s)
        {
            Name = name;
            this.cylindersCount = cylindersCount;

            cylinder = new Cylinder(d, s);
        }

        public double GetEngineVolume()
        {
            return cylinder.GetVolumeCylinder() * cylindersCount;
        }

    }
}
