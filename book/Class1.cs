using System;
using System.Collections.Generic;
using System.Text;

namespace Day_9
{
    public class idException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "book id should be of 5 digits. re-enter";
            }
        }
    }


    public class blankException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "this field cannot be blank. re-enter";
            }
        }
    }

    public class lotException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "LoT can have values from the below list only :\n 1.NET , 2.Java, 3.IMS, 4.V&V, 5.BI, 6.RDBMS . re-enter";
            }
        }
    }

    class book_management
    {
        private string book_id, book_name, isbn_no, price, publisher, pages, language, lot, summary;

        public book_management()
        {
            this.language = "English";
            this.lot = "Technical";
        }

        private bool valid_number(string s)
        {
            foreach (char c in s)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    return true;
                }
            }
            return false;
        }

        private bool valid_string(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (c == ' ' && count == 0) return true;
                if (!((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z' || c == ' ')))
                {
                    return true;
                }
                count += 1;
            }
            return false;
        }


        public void set_id()
        {
            this.book_id = Console.ReadLine();
            if (valid_number(this.book_id))
            {
                Console.WriteLine("invalid book id re-enter");
                set_id();
            }
            try
            {
                if (this.book_id.Length == 0) throw new blankException();
                if (this.book_id.Length != 5) throw new idException();
            }
            catch (idException one)
            {
                Console.WriteLine(one.Message);
                set_id();
            }
            catch (blankException one)
            {
                Console.WriteLine(one.Message);
                set_id();
            }
        }

        public void get_id()
        {
            Console.WriteLine(this.book_id);
        }

        public string get_id(int x)
        {
            return this.book_id;
        }

        public void set_name()
        {
            this.book_name = Console.ReadLine();
            if (valid_string(this.book_name))
            {
                Console.WriteLine("invalid book_name re-enter");
                set_name();
            }
            try
            {
                if (this.book_name.Length == 0) throw new blankException();
            }
            catch (idException one)
            {
                Console.WriteLine(one.Message);
                set_name();
            }

        }

        public void get_name()
        {
            Console.WriteLine(this.book_name);
        }

        public void set_isbn()
        {
            this.isbn_no = Console.ReadLine();
            if (this.isbn_no.Length == 0 || valid_number(this.isbn_no))
            {
                Console.WriteLine("invalid isbn_no re-enter");
                set_isbn();
            }
        }

        public void get_isbn()
        {
            Console.WriteLine(this.isbn_no);
        }

        public void set_price()
        {
            this.price = Console.ReadLine();
            if (this.price.Length == 0 || valid_number(this.price))
            {
                Console.WriteLine("invalid price re-enter");
                set_price();
            }
        }

        public void get_price()
        {
            Console.WriteLine(this.price);
        }

        public void set_publisher()
        {
            this.publisher = Console.ReadLine();
            if (this.publisher.Length == 0 || valid_string(this.publisher))
            {
                Console.WriteLine("invalid publisher re-enter");
                set_publisher();
            }
        }

        public void get_publisher()
        {
            Console.WriteLine("this.publisher");
        }

        public void set_pages()
        {
            this.pages = Console.ReadLine();
            if (pages.Length == 0 || valid_number(pages))
            {
                Console.WriteLine("invalid pages re-enter");
                set_pages();
            }
        }

        public void get_pages()
        {
            Console.WriteLine(this.pages);
        }

        public void set_language()
        {
            this.language = Console.ReadLine();
            if (this.language.Length == 0 || valid_string(this.language))
            {
                Console.WriteLine("invalid language re-enter");
                set_language();
            }
        }

        public void get_language()
        {
            Console.WriteLine(this.language);
        }

        public void set_lot()
        {
            this.lot = Console.ReadLine();
            if (lot.Length == 0)
            {
                Console.WriteLine("invalid lot re-enter");
                set_lot();
            }
            try
            {
                if (!(this.lot == ".NET" || this.lot == "Java" || this.lot == "IMS" || this.lot == "V&V" || this.lot == "BI" || this.lot == "RDBMS"))
                {
                    throw new lotException();
                }
            }
            catch (lotException one)
            {
                Console.WriteLine(one.Message);
                set_lot();
            }
        }

        public void get_lot()
        {
            Console.WriteLine(this.lot);
        }

        public void set_summary()
        {
            this.summary = Console.ReadLine();
            if (summary.Length == 0 || valid_string(this.summary))
            {
                Console.WriteLine("invalid summary re-enter");
                set_summary();
            }
        }

        public void get_summary()
        {
            Console.WriteLine(this.summary);
        }
    }

    class file
    {
        public static void Main(string[] args)
        {

            var map = new Dictionary<string, book_management>();
            while (true)
            {
                Console.WriteLine("ENTER THE CHOICE NO.\n");
                Console.WriteLine("1. add book");
                Console.WriteLine("2. delete book");
                Console.WriteLine("3. show book from collection");
                Console.WriteLine("0. exit");

                int choose = -1;
                string str = Console.ReadLine();
                choose = Convert.ToInt32(str);
                if (!(choose >= 0 && choose <= 3))
                {
                    Console.WriteLine("invalid Choice");
                    return;
                }

                switch (choose)
                {
                    case 1:
                        book_management obj = new book_management();
                        Console.WriteLine("fill book ID :");
                        obj.set_id();
                        Console.WriteLine("\nfill book name :");
                        obj.set_name();
                        Console.WriteLine("\nfill book isbn no :");
                        obj.set_isbn();
                        Console.WriteLine("\nfill book price :");
                        obj.set_price();
                        Console.WriteLine("\nfill book publisher :");
                        obj.set_publisher();
                        Console.WriteLine("\nfill book pages :");
                        obj.set_pages();
                        Console.WriteLine("\nfill book summary :");
                        obj.set_summary();
                        Console.WriteLine("\nfor filling lot and language press 1 or any key to skip.");
                        string str1 = Console.ReadLine();
                        if (str1 == "1")
                        {
                            Console.WriteLine("\nfill book language :");
                            obj.set_language();
                            Console.WriteLine("\nfill book lot :");
                            obj.set_lot();
                        }
                        map.Add(obj.get_id(0), obj);
                        Console.WriteLine("\n book added successfuly.");
                        break;
                    case 2:
                        Console.WriteLine("\nenter book id to delete book");
                        string s = Console.ReadLine();
                        if (map.ContainsKey(s))
                        {
                            map.Remove(s);
                            Console.WriteLine("\n book removed successfuly");
                        }
                        else
                        {
                            Console.WriteLine("\nno book found from this id.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nenter book id to see book");
                        string st = Console.ReadLine();
                        if (map.ContainsKey(st))
                        {
                            book_management o1 = map[st];
                            Console.WriteLine("book ID :");
                            o1.get_id();
                            Console.WriteLine("\nbook name :");
                            o1.get_name();
                            Console.WriteLine("\nbook isbn no :");
                            o1.get_isbn();
                            Console.WriteLine("\nbook price :");
                            o1.get_price();
                            Console.WriteLine("\nbook publisher :");
                            o1.get_publisher();
                            Console.WriteLine("\nbook pages :");
                            o1.get_pages();
                            Console.WriteLine("\nbook summary :");
                            o1.get_summary();
                            Console.WriteLine("\nbook language :");
                            o1.get_language();
                            Console.WriteLine("\nbook lot :");
                            o1.get_lot();
                        }
                        else
                        {
                            Console.WriteLine("\nno book found from this id.");
                        }
                        break;
                    case 0:
                        return;
                }
                Console.WriteLine("\n opration successful.\n\n");
            }

        }

    }
}






