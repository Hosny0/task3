namespace task3
{
    
    
       
     

class Book
        {
            public string Title;
            public string Author;
            public string ISBN;
            public bool Availability;

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                Availability = true; 
            }
        }

        class Library
        {
            public List<Book> books = new List<Book>();

            public void AddBook(string title, string author, string isbn)
            {
                books.Add(new Book(title, author, isbn));
                Console.WriteLine("done");
            }

            public void SearchBook(string keyword)
            {
                foreach (var book in books)
                {
                    if (book.Title.Contains(keyword) || book.Author.Contains(keyword))
                    {
                        Console.WriteLine("title: " + book.Title + " Author " + book.Author + ", ISBN: " + book.ISBN + "available" + (book.Availability));
                    }
                }
            }

            public void BorrowBook(string isbn)
            {
                foreach (var book in books)
                {
                    if (book.ISBN == isbn && book.Availability)
                    {
                        book.Availability = false;
                        Console.WriteLine("done  ," + book.Title);
                        return;
                    }
                }
                Console.WriteLine("not available.");
            }

            public void ReturnBook(string isbn)
            {
                foreach (var book in books)
                {
                    if (book.ISBN == isbn && !book.Availability)
                    {
                        book.Availability = true;
                        Console.WriteLine(" return done " + book.Title);
                        return;
                    }
                }
                Console.WriteLine("The book was not found or was not borrowed.");
            }
        }

        class Program
        {
            static void Main()
            {
                Library library = new Library();

                library.AddBook("music", " hosny", "123");
                library.AddBook("football", "ashraf", "456");
                

                Console.WriteLine("\n search book");
                library.SearchBook("music");

                Console.WriteLine("\n borrow book");
                library.BorrowBook("123");

                Console.WriteLine(" \n Condition of books after borrowing");
                library.SearchBook("");

                Console.WriteLine("\n Return the book:");
                library.ReturnBook("123");

                Console.WriteLine("\n Condition of books befor borrowing :");
                library.SearchBook("");
            }
        }

    }


