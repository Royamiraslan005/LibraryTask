using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Book
    {
        public static int _ID;
        public int Id {  get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price {  get; set; }

        public Book(string name,string authorname,double price)
        {
            _ID=Id;
            Name=name;
            AuthorName=authorname;
            Price=price;
        }
        public string ShowInfo()
        {
            return $"Id={Id},Name={Name},AuthorName={AuthorName},Price={Price}";
        }
        public override string ToString()
        {
            return ShowInfo() ;
        }




    }
}
