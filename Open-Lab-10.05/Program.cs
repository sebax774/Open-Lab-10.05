using System;
using System.Collections.Generic;


namespace Open_Lab_10._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("The Return of the King", 416, "Fantasy", "J.R.R. Tolkien", 2003);

            Book LOTR2 = new Book();

            Book LOTR3 = new Book("The Fellowship of the Ring", 0);

            Book HOBIT = new Book("Hobbit", 423, "Fantasy", "J.R.R. Tolkien", 1954);

            {
                Category = Book.categoryList[4];
            }

            LOTR.PrintBookInfo();

            LOTR2.PrintBookInfo();

            LOTR3.PrintBookInfo();

            HOBIT.PrintBookInfo();

            Console.ReadKey();
        }
    }
    class Book
    {

        private string empty = ", ";

        private int pages;

        private string title;

        private string category;

        private string author;

        private int releaseDate;
        /// List of available categories.
        public static List<string> categoryList = new List<string>();

        public Book(string ttl, int pgs, string ctgr, string athr, int dt)
        {

            title = ttl;

            pages = pgs;

            category = ctgr;

            author = athr;

            releaseDate = dt;

            categoryList.Add("for kids");

            categoryList.Add("romantic");

            categoryList.Add("educational");

            categoryList.Add("sci-fi");

            categoryList.Add("adventure");
        }

        public Book()
        {

            title = "-1";

            pages = -1;

            category = "-1";

            author = "-1";

            releaseDate = -1;
        }
        public Book(string ttl, int pgs)
        {
            title = ttl;

            pages = pgs;

            category = "-1";

            author = "-1";

            releaseDate = -1;
        }

        /// Property, that set up a title of book.
        public string Title
        {
            get => this.title;
            set

            {
                this.title = value;
            }
        }

        /// Property, that set up a number of pages in book.
        public int Pages
        {
            get => this.pages;
            set

            {

                this.pages = value;
                if (this.pages < 0)

                {
                    this.pages = 1;
                }
            }
        }

        /// Property, that set up a category of book.
        public string Category
        {

            set

            {
                this.category = value;
            }
        }

        /// Property, that set up an author of book.
        public string Author
        {

            get => this.author;
            set

            {
                this.author = value;
            }
        }

        /// Property, that set up release date of book.
        public int ReleaseDate
        {
            get => this.releaseDate;
            set
            {

                this.releaseDate = value;
                if ((this.releaseDate > 2021) || (this.releaseDate < 1450))

                {
                    this.releaseDate = -1;
                }
            }
        }
        public void PrintBookInfo()
        {
            Console.WriteLine(author + empty + title + empty + pages + empty + category + empty + releaseDate);
        }
    }
}