using System;

namespace Ex2
{
    public abstract class BaseClass
    {
        public double weight { get; set; }
        public string name { get; set; }
        

        public void Show()
        {
            Console.WriteLine($"Name = {name}, Weight = {weight}");
        }

        public abstract void SetMe(string name, double weight);
    }
}