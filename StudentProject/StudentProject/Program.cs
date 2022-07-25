using System;

namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("Michał", "Tokarczyk",1);

            Console.WriteLine(student.ShowStudent());
        }
    }
}
