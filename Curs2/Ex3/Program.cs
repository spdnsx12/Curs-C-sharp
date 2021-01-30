using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float pounds;
            float pounds_rate = 2.2046f;
            Console.Write("Enter pounds value: ");
            pounds = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} pounds in KG means: {1}", pounds,pounds/pounds_rate);


        }
    }
}