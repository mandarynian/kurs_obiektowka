using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Student
    {
        private string Name;
        private string Surname;
        private int Points;

        public Student(string name, 
            string surname, 
            int points)
        {
            Name = name;
            Surname = surname;
            Points = points;
        }

        public string ShowStudent()
        {
            var auraColor = "red";

            var satysfactionLevel = new Random().Next(20);

            if (satysfactionLevel >= 6)
            {
                auraColor = "orange";
            }
            
            if (satysfactionLevel >= 11)
            {
                auraColor = "purple";
            }
            
            if (satysfactionLevel >= 16)
            {
                auraColor = "green";
            }

            return @$"Student: {Name} {Surname} 
                posiada kolor aury: {auraColor} 
                osiągając wynik aury: {satysfactionLevel}";
        }
    }
}
