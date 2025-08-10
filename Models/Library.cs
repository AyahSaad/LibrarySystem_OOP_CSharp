
using Demo.Models;
public class Library
{
    private List<Book> books;
    private List<AbstractPerson> members;

    public Library()
    {
        books = new List<Book>();
        members = new List<AbstractPerson>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddMember(AbstractPerson member)
    {
        members.Add(member);
    }

    public Book? FindBookById(int id)
    {
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }
        return null;
    }


    public AbstractPerson? FindMemberById(int id)
    {
        foreach (AbstractPerson member in members)
        {
            if (member.Id == id)
            {
                return member;
            }
        }
        return null;
    }

    public void DisplayAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            Console.WriteLine("--- Books List ---");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }
    }

    public void DisplayAllMembers()
    {
        if (members.Count == 0)
        {
            Console.WriteLine("No members in the library.");
        }
        else
        {
            Console.WriteLine("--- Members List ---");
            foreach (var member in members)
            {
                member.DisplayInfo();
            }
        }
    }
}
