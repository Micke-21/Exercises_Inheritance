using System;

namespace Exercises_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises: Inhetithae\n");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
