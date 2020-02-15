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
            Console.BackgroundColor = ConsoleColor.Gray;//Set up the display window
            Console.Clear(); //background is now that colour
            Console.ForegroundColor = ConsoleColor.DarkGreen; //sets font colour
            Console.Title = "Library"; //app title


            Book bookObj = new Book(); //create an object of class Book

            bookObj.Start(); //use object Book
            Console.WriteLine(); //spacing
            bookObj.ReadAndSaveBookInfo();  //ask for info
            Console.WriteLine(); //spacing
            Console.WriteLine("**********************************"); //division spacing
            Console.WriteLine(); //spacing
            bookObj.DisplayBookInfo(); //display
            Console.WriteLine(); //spacing
            Console.WriteLine("**********************************"); //division spacing
            Console.WriteLine("Press enter to exit.");//exit dialogue
            Console.ReadLine(); //message stays on screen until key pressed
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
            Console.WriteLine("**********************************"); //gives dividing line
            Console.WriteLine("Please enter the book's author    "); //asks author
            author = Console.ReadLine(); //sets author value. it is already a string so no need to convert
            }//author

            public void ReadPubYear()
            {
            Console.Write("What year was the book published?    ");
            string textValue = Console.ReadLine(); //read response to pubyear q
            pubYear = int.Parse(textValue); //convert string to number
            }//pubyear

            public void ReadFiction()
            {
            Console.Write("Is the book fiction?  (Y/N) ");
            char response = char.Parse(Console.ReadLine()); //what characters does the answer contain
            if ((response == 'y') || (response == 'Y')) // y or Y means true
            { isFiction = true; }
            else
            { isFiction = false; }
            }//fiction

            public void ReadAndSaveBookInfo()//gathers together the three mini methods to be called from one
            {
            ReadAuthor();
            ReadPubYear();
            ReadFiction();
            }//read info

            public void DisplayBookInfo()
            {
            string authorOut = "Author: "+author+""; //create string authorOut
            string pubyearOut = "Year of publication: "+pubYear+""; //create string pubyearOut
            
             Console.WriteLine(authorOut); //print author
             Console.WriteLine(pubyearOut); //print pubyear
    
              if
                 (isFiction == true) //check value of bool
                Console.WriteLine("This book should be shelved with fiction.");
             if
                 (isFiction == false) //check value of bool
                Console.WriteLine("This book should be shelved with nonfiction.");

        }//display

        }//class book

}//namespace
