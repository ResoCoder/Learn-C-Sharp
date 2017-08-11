using System;

namespace LearnCSharp
{
    class Person
    {
        public double Height;
        public double Weight;
        public string HairColor;

        public Person(double height, double weight, string hairColor)
        {
            Height = height;
            Weight = weight;
            HairColor = hairColor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person John = new Person(180, 73.5, "brown");
            Console.WriteLine(John.Weight);

            Console.ReadLine();
        }
    }
}
