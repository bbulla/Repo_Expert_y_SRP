using System;

// Clase para representar la información básica de un libro
public class BookInfo
{
    public string Title { get; }
    public string Author { get; }
    public string Code { get; }

    public BookInfo(string title, string author, string code)
    {
        Title = title;
        Author = author;
        Code = code;
    }
}
