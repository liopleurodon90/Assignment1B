using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshelf
{
    class Shelf
    {
        static void Main(string[] args)
        {
            Book bookObj = new Book(); //create an object of class Book

            bookObj.Start(); //use object Book
            bookObj.ReadAuthor();  //ask for author
        }//main
    }//class shelf
    
    class Book
    {
        private string author; //books author
        private int pubYear; //year of publication
        private bool isFiction; //true if fiction false if nonfiction

        public void Start()
        {
            Console.WriteLine(); //gives blank line
            Console.WriteLine("Welcome to your library!"); //greetings from this project
            Console.WriteLine(); //gives blank line

        }//start

        public void ReadAuthor()
        {
            Console.WriteLine(*******************); //gives dividing line
            Console.WriteLine("Please enter the book's author     "); //asks author
            author = Console.ReadLine(); //sets author value
        }


        }//class book

}//namespace
