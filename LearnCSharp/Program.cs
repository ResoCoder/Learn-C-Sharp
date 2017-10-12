using System;

namespace LearnCSharp
{
    interface IWalking
    {
        void Walk();
    }

    class Animal : IWalking
    {
        public void Walk()
        {
            Console.WriteLine("I walked 5000 meters");
        }
    }

    class Person : IWalking
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

        public void Walk()
        {
            Console.WriteLine("I walked 1000 meters");
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
            //Jeff.Walk();

            Person Paul = new Person(160, 50, "green");
            //Paul.Walk();

            Person[] people = new Person[3];
            people[0] = Jeff;
            people[1] = Paul;

            //people[0].Walk();
            //people[1].Walk();

            IWalking[] creatures = new IWalking[3];
            creatures[0] = Jeff;
            creatures[1] = Paul;
            creatures[2] = new Animal();

            foreach (var creature in creatures)
                creature.Walk();

            Console.ReadLine();
        }
    }
}