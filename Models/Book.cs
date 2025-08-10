namespace Demo.Models;

public class Book
{
    public int Id { get; }
    public string Title { get; }
    public string AuthorName { get; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string authorName)
    {
        Id = id;
        Title = title;
        AuthorName = authorName;
        IsAvailable = true;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Title: {Title}, Author: {AuthorName}, Available: {IsAvailable}");
    }
}
