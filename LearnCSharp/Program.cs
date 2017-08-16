using System;

namespace LearnCSharp
{
    class Person
    {
        public double Height;
        public double Weight;
        public string HairColor;
        protected bool HasUnderwear;

        public Person(double height, double weight, string hairColor, bool hasUnderwear)
        {
            Height = height;
            Weight = weight;
            HairColor = hairColor;
            HasUnderwear = hasUnderwear;
        }

        public Person(double height, double weight, string hairColor) 
            : this(height, weight, hairColor, true)
        {

        }

        public virtual void Talk()
        {
            Console.WriteLine("I am a person. Nice to meet you!");
        }
    }

    class Programmer : Person
    {
        public string FavoriteProgrammingLanguage;

        public Programmer(double height, double weight, string hairColor, bool hasUnderwear, 
            string favLang) 
            : base(height, weight, hairColor, hasUnderwear)
        {
            FavoriteProgrammingLanguage = favLang;
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine($"I like {FavoriteProgrammingLanguage} and I have underwear = {HasUnderwear}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer Jeff = new Programmer(179, 80, "black", false, "C#");
            Jeff.Talk();

            Console.ReadLine();
        }
    }
}