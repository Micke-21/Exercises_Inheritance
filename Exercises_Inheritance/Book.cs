using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;
        public string Author
        {
            get { return this.author; }
            private set
            {
                //
                var lastName = value.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                var firstChar = lastName[0];

                if (char.IsDigit(firstChar))
                    throw new ArgumentException("Author not valid!");
                this.author = value;
            }
        }
        public string Title
        {
            get { return this.title; }
            private set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                this.title = value;
            }
        }
        public virtual decimal Price
        {
            get { return this.price; }
            private set
            {
                if (price < 0)
                    throw new ArgumentException("Price not valid");
                this.price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
                .AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");

            string result = resultBuilder.ToString().TrimEnd();

            return result;
        }

    }
}
