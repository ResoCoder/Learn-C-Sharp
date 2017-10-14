using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(ConcatenateArray(integers));

            char[] characters = new char[] { 'a', 'b', 'c', 'd', 'e' };
            Console.WriteLine(ConcatenateArray(characters));

            List<string> strings = new List<string>() { "hello", "everyone" };
            Console.WriteLine(ConcatenateCollection(strings));
            Console.WriteLine(ConcatenateCollection(characters));

            var holder = new TwoCollectionHolder<List<string>, int[]>(strings, integers);
            Console.WriteLine(holder.ToConcatenatedString());
            Console.WriteLine(holder.GetTypeOfCollections());

            Console.ReadLine();
        }

        static string ConcatenateIntArray(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
                sb.Append(item);
            return sb.ToString();
        }

        static string ConcatenateCharArray(char[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
                sb.Append(item);
            return sb.ToString();
        }

        static string ConcatenateArray<T>(T[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in array)
                sb.Append(item);
            return sb.ToString();
        }

        static string ConcatenateCollection<T>(T collection) where T : IList
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collection)
                sb.Append(item);
            return sb.ToString();
        }
    }

    class TwoCollectionHolder<T, U> where T : IList where U : IList
    {
        private T collection1;
        private U collection2;

        public TwoCollectionHolder(T c1, U c2)
        {
            collection1 = c1;
            collection2 = c2;
        }

        public string ToConcatenatedString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collection1)
                sb.Append(item);
            foreach (var item in collection2)
                sb.Append(item);
            return sb.ToString();
        }

        public Tuple<Type, Type> GetTypeOfCollections() => new Tuple<Type, Type>(typeof(T), typeof(U));

        private T CompletelyNotUsefulMethod() => collection1;
    }
}