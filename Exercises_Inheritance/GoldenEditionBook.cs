using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    internal class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
            //Author = author;
            //Title = title;
            //Price = price;
        }

        //public string Author { get; }
        //public string Title { get; }
        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)1.3;
            }
            //set { 

            //} 
        }
    }
}
