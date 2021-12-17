using System;

namespace Exercises_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Exercises: Inhetithae\n");
                //P1_Person();
                //P2_Book();
                P3_Mankind();
            } while (true);
        }

        private static void P3_Mankind()
        {
            try
            {
                Console.Write("Student Name and Faculty Number: ");
                string studentInput = Console.ReadLine();
                Console.Write("Worker First- Last Name Week Salary Hours per day: ");
                string workerInput = Console.ReadLine();

                var sPars = studentInput.Split(" ", StringSplitOptions.RemoveEmptyEntries); //'\u002C'
                var student = new Student(sPars[0], sPars[1], sPars[2]);

                var wPars = workerInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var worker = new Worker(wPars[0], wPars[1], decimal.Parse(wPars[2]), decimal.Parse(wPars[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        private static void P2_Book()
        {
            try
            {

                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }

        private static void P1_Person()
        {
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
