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


        public Engine(string name, int cylindersCount)
        {
            cylinder = new Cylinder();
            Name = name;
            this.cylindersCount = cylindersCount;
        }

        public double GetEngineVolume()
        {
            return cylinder.GetVolumeCylinder() * cylindersCount;
        }

    }
}
