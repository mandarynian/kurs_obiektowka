using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliczaniePojemnosciSkokowejSilnika.Engines
{
    public class Engine
    {
        public string Name { get; set; }

        public List<Cylinder> Cylinders { get; set; }

        private int cylindersCount;


        public Engine(string name, int cylindersCount)
        {
            Name = name;
            this.cylindersCount = cylindersCount;
        }

        public double GetEngineVolume()
        {
            return 0;
        }

    }
}
