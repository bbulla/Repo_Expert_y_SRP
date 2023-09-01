/*
{
    public class Book
    {

        public string Title { get ; } 
        public string Author { get ; }
        public string Code { get ;  }

        // Estos 3 atributos cumplen con el principio de SRP ya que dependen de si mismos y son básicos
        //solamente almacenan la info básica del libro


        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        // Son dos propiedades relacionadas a la posición del libro, por lo que violan el principio de SRP ya que 
        // la razón para cambiar la clase podría ser tanto una modificación en la información básica del libro 
        //como en su ubicación en la biblioteca.

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        //: El constructor se encarga de inicializar los atributos básicos del libro. 
        //Cumple con el SRP, ya que su única responsabilidad es asignar valores iniciales a las propiedades esenciales del libro.

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        //Este método asigna la ubicación del libro en la biblioteca. 
        //Como en LibrarySector y LibraryShelve, esto es una responsabilidad adicional en la clase, violando el SRP.

    }
}
*/

using System;

public class Book
{
    public BookInfo Info { get; }
    public LibraryLocation Location { get; }

    public Book(string title, string author, string code)
    {
        Info = new BookInfo(title, author, code);
        Location = new LibraryLocation();
    }

    public void SetLocation(string sector, string shelve)
    {
        Location.Sector = sector;
        Location.Shelve = shelve;
    }
}
