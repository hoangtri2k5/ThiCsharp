using System;

namespace Ex2
{
    internal class Program
    {
        public class Tyger:BaseClass
        {

            public override void SetMe( string Name, double Weight)
            {
                name = Name;
                weight = Weight;
            }
        }
        
        public class Lion:BaseClass
        {
            public override void SetMe( string Name, double Weight)
            {
                name = Name;
                weight = Weight;
            }
        }
        
        public static void Main(string[] args)
        {
            Tyger tyger = new Tyger();
            tyger.SetMe("Tyger", 100);
            tyger.Show();
            Lion lion = new Lion();
            lion.SetMe("Lion", 200);
            lion.Show();
        }
    }
}