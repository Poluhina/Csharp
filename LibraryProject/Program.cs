using System;
using System.Collections.Generic;

class BookInfo
{
    public int Year = 0;
    public bool IsTaken = false;
}

class Book
{
    public string Title = "";
    public BookInfo Info = new BookInfo();
}

class LibraryState
{
    public List<Book> Books = new();
}

class Program
{
    static void BorrowBook(LibraryState state, string name)
    {
        foreach (var book in state.Books)
        {
            if (book.Title == name)
            {
                if (book.Info.IsTaken)
                {
                    Console.WriteLine("Книга уже взята.");
                    return;
                }

                book.Info.IsTaken = true;
                Console.WriteLine($"Книга \"{name}\" взята.");
                return;
            }
        }

        Console.WriteLine("Книга не найдена!");
    }

    static void ReturnBook(LibraryState state, string name)
    {
        bool found = false;

        foreach (var book in state.Books)
        {
            if (book.Title == name)
            {
                found = true;

                if (!book.Info.IsTaken)
                {
                    Console.WriteLine("Эта книга и так свободна.");
                    return;
                }

                book.Info.IsTaken = false;
                Console.WriteLine($"Книга \"{name}\" возвращена.");
                return;
            }
        }

        if (!found)
        {
            Console.WriteLine("Ошибка! Такой книги нет.");
        }
    }

    static void ShowBooks(LibraryState state)
    {
        Console.WriteLine("\nСписок книг:");

        foreach (var book in state.Books)
        {
            string status = book.Info.IsTaken ? "Взята" : "Свободна";
            Console.WriteLine($"{book.Title}, {book.Info.Year} — {status}");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        var state = new LibraryState();

        state.Books.Add(new Book()
        {
            Title = "Мастер и Маргарита",
            Info = new BookInfo()
            {
                Year = 1967,
            }
        });

        state.Books.Add(new Book()
        {
            Title = "1984",
            Info = new BookInfo()
            {
                Year = 1949,
            }
        });

        state.Books.Add(new Book()
        {
            Title = "Гарри Поттер",
            Info = new BookInfo()
            {
                Year = 1997,
            }
        });

        state.Books.Add(new Book()
        {
            Title = "Война и мир",
            Info = new BookInfo()
            {
                Year = 1869,
            }
        });

        state.Books.Add(new Book()
        {
            Title = "Преступление и наказание",
            Info = new BookInfo()
            {
                Year = 1866,
            }
        });

        BorrowBook(state, "1984");
        BorrowBook(state, "Телепузики");
        ReturnBook(state, "1984");
        ReturnBook(state, "Несуществующая");

        ShowBooks(state);
    }
}
