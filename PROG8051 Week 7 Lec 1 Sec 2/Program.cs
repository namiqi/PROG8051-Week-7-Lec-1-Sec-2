using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{

    class Book
    {
        // Fields
        string title;
        string author;
        string isbn;
        bool isAvailable = true;


        // Properties
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public string Isbn { get { return isbn; } }
        public bool IsAvailable { get { return isAvailable; }  set { isAvailable = value; } }

        // Constructor
        public Book(string Btitle, string BAuthor, string Bisbn)
        {
            title = Btitle;
            author = BAuthor;
            isbn = Bisbn;
        }


    }

    class Library
    {
        Book[] books = new Book[10];
        int count = 0;

        public void AddBook(Book book)
        {
            books[count++] = book;
        }

        public void ListAvailableBooks()
        {
           //implement the logic
        }

        public void CheckOutBook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if(books[i].Isbn == isbn && books[i].IsAvailable)
                {
                    books[i].IsAvailable = false;
                    Console.WriteLine($"Book checked out, here is the remaining available books");
                    
                    break;
                }
                
                
            }
            ListAvailableBooks();
        }

        public void ReturnBook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn && !books[i].IsAvailable)
                {
                    books[i].IsAvailable = true;
                    Console.WriteLine($"Book return, here is the remaining available books");

                    break;
                }


            }
            ListAvailableBooks();
        }

        public void RemoveBook(string isbn)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn )
                {
                    index = i;
                }


            }


            books[index] = null;

            for(int i = index; i < count-1; i++)
            {
                books[i] = books[i + 1];
            }

            count--;

            Console.WriteLine("-------------");
            ListAvailableBooks();

        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwell", "1a1s2s3s");
            Book book2 = new Book("C++", "Dan", "4651as");
            Book book3 = new Book("C", "Milton", "4545s");


            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);

            library.AddBook(book3);
            library.ListAvailableBooks();
            library.CheckOutBook("4651as");
            library.ReturnBook("4651as");

            library.RemoveBook("1a1s2s3s");
        }
    }

   /* class DealerShip {
         int inventory = 4;

       // Properties

        public int Inventory { 
            get { return inventory; } 
            set { inventory = value; } 
        }
    }


    class Car
    {
        // Class members

        // Fields
        int numofDoors = 4;
        int engineSize;
        string color;

        // Methods
        public void Honk(string model)
        {
            Console.WriteLine($"{model} Honk Honk");
        }

        // Constructor
        public Car(int CengineSize, string Ccolor) {
            
            engineSize = CengineSize;
            color = Ccolor;
        }

        // Access modifiers

        static void Main(string[] args)
        {
            DealerShip waterloo = new DealerShip();

            Console.WriteLine(waterloo.Inventory);
            waterloo.Inventory = 15;
            
            Console.WriteLine(waterloo.Inventory);
            Console.WriteLine("----------------");

            // How to create an object

            // Classname objectname = new Classname()

            Car lexus = new Car(3500,"red");

           


            Console.WriteLine(lexus.numofDoors);
            Console.WriteLine(lexus.engineSize);
            lexus.Honk("lexus");
            
            Car bmw = new Car(4500,"green");
           
            


            bmw.Honk("BMW");
            Console.WriteLine(bmw.numofDoors);
            Console.WriteLine(bmw.engineSize);

        }
    }*/
}