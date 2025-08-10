
using Demo.Models;
public abstract class AbstractPerson
{
    public int Id { get; }
    public string Name { get; }
    public List<Book> BorrowedBooks { get; }

    public AbstractPerson(int id, string name)
    {
        Id = id;
        Name = name;
        BorrowedBooks = new List<Book>();
    }

    public abstract void DisplayInfo();

    public void BorrowBook(Book book)
    {
        if (book.IsAvailable)
        {
            BorrowedBooks.Add(book);
            book.IsAvailable = false;
            Console.WriteLine($"{Name} borrowed \"{book.Title}\".");
        }
        else
        {
            Console.WriteLine($"Book \"{book.Title}\" is not available.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            book.IsAvailable = true;
            Console.WriteLine($"{Name} returned \"{book.Title}\".");
        }
        else
        {
            Console.WriteLine($"{Name} hasn't borrowed \"{book.Title}\".");
        }
    }

    public void DisplayBorrowedBooks()
    {
        if (BorrowedBooks.Count == 0)
        {
            Console.WriteLine($"{Name} has not borrowed any books.");
        }
        else
        {
            Console.WriteLine($"{Name} borrowed books:");
            foreach (var book in BorrowedBooks)
            {
                book.DisplayInfo();

            }
        }
    }
}
