using System;
using ObliczaniePojemnosciSkokowejSilnika.Engines;

namespace ObliczaniePojemnosciSkokowejSilnika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine nazwijjajakchcesz = new Engine("silniksubaru",4, 92, 75);           
            double objetosc = nazwijjajakchcesz.GetEngineVolume();
            Console.WriteLine(objetosc);
        }
    }
}
