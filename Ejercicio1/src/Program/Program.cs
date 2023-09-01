using System;

namespace Ucu.Poo.Expert
{
    class Program
    {
        static void Main()
        {
            // Crear objetos de libros
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            Book book2 = new Book("Pro C#", "Troelsen", "001-035");

            // Establecer ubicaciones de los libros
            book1.SetLocation("A", "7");
            book2.SetLocation("B", "3");

            // Imprimir la información de los libros y sus ubicaciones
            Console.WriteLine("Book 1:");
            Console.WriteLine($"Title: {book1.Info.Title}");
            Console.WriteLine($"Author: {book1.Info.Author}");
            Console.WriteLine($"Code: {book1.Info.Code}");
            Console.WriteLine($"Location: Sector {book1.Location.Sector}, Shelve {book1.Location.Shelve}");

            Console.WriteLine("\nBook 2:");
            Console.WriteLine($"Title: {book2.Info.Title}");
            Console.WriteLine($"Author: {book2.Info.Author}");
            Console.WriteLine($"Code: {book2.Info.Code}");
            Console.WriteLine($"Location: Sector {book2.Location.Sector}, Shelve {book2.Location.Shelve}");
        }
    }
}
