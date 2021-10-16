using System;

namespace GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Demenstions of the Cylinder");
            Cylinder cylinder = new Cylinder();
            cylinder.Radius = 38.64;
            cylinder.Height = 22.48;
            cylinder.Process();
            cylinder.Result();
        }
    }
}