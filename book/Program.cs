using day_9;
using System;
using System.Collections.Generic;


namespace day_9
{ 
        class Book
        {
            public int BookId;
            public string BookName;
            public string Publisher;
            public int Price;
            public int NoPages;
            public string Language;
            public string LoT;
            public string Summary;
            public int ISBN;
        }
        class Library : Book
        {
            public void GetData()
            {
                Console.WriteLine("Book ID is a mandatory Field,It can't be empty.Please enter Book ID : ");
                BookId = Convert.ToInt32(Console.ReadLine());
                {
                    if (BookId > 5 || BookId < 5)
                    {
                        Console.WriteLine("Please Enter 5 Digit Number: ");
                        BookId = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Please enter your BookName");
                BookName = Console.ReadLine();
                while (string.IsNullOrEmpty(BookName))
                {
                    Console.WriteLine("Book Name is a mandatory Field,It can't be empty. Please enter Book Name: ");
                    BookName = Console.ReadLine();
                }
                Console.WriteLine("Please enter Publisher");
                Publisher = Console.ReadLine();
                Console.WriteLine("Please enter Price");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Pages");
                NoPages = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Language");
                Language = Console.ReadLine();
                Console.WriteLine("Please enter lot");
                LoT = Console.ReadLine();
                if (LoT != ".NET" || LoT != "Java" || LoT != "IMS" || LoT != "V&V" || LoT != "BI" || LoT != "RDBMS")
                {
                    Console.WriteLine("Please Enter correct Value!");
                    LoT = Console.ReadLine();
                }
                Console.WriteLine("Please enter summary");
                Summary = Console.ReadLine();
                Console.WriteLine("Enter ISBN Number: ");
                ISBN = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    class Class7
    {
        public static void Main()
        {
            bool flag = true;
            List<Book> b = new List<Book>();
            Library l = new Library();
            while (flag)
            {
                Console.WriteLine("Please enter the choice you want to do \n1.Add Details \n2.Display");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Details:");
                        l.GetData();
                        b.Add(l);
                        break;
                    case 2:
                        Console.WriteLine("Details Are:");
                        Console.WriteLine("Book Id: " + l.BookId);
                        Console.WriteLine("Book Name: " + l.BookName);
                        Console.WriteLine("Publisher Name: " + l.Publisher);
                        Console.WriteLine("Price: " + l.Price);
                        Console.WriteLine("No. of Pages: " + l.NoPages);
                        Console.WriteLine("Language: " + l.Language);
                        Console.WriteLine("LoT: " + l.LoT);
                        Console.WriteLine("Summary: " + l.Summary);
                        Console.WriteLine("ISBN Number: " + l.ISBN);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice!");
                        break;
                }
                if (!flag)
                {
                    break;
                }
            }
        }
    }







