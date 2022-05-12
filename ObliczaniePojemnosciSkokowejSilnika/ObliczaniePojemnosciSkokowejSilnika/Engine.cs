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


        public Engine(string name)
        {
            Name = name;
        }

        public double GetEngineVolume()
        {
            return 0;
        }

    }
}
