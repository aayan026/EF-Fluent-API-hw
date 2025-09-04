
using Fulent_API.Context;
using Fulent_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static async Task Main(string[] args)
    {

        var context = new AppDbContext();

        //context.Themes.AddRange(
        //    new Theme { Name = "Philosophy" },
        //    new Theme { Name = "Romance" },
        //    new Theme { Name = "Drama" }
        //);
        //context.Authors.AddRange(
        //new Author { FirstName = "Fyodor", LastName = "Dostoevsky" },
        //new Author { FirstName = "Gabriel", LastName = "Marquez" },
        //new Author { FirstName = "Jane", LastName = "Austen" }
        //);
        //context.Categories.AddRange(
        //new Category {  Name = "Novel" },
        //new Category {  Name = "Fiction" },
        //new Category { Name = "Romance" }
        //);
        //context.Presses.AddRange(
        //new Press {  Name = "Penguin" },
        //new Press {  Name = "HarperCollins" },
        //new Press { Name = "Oxford Press" }
        //);
        //context.Libs.AddRange(
        //    new Libs { FirstName = "Central ", LastName = "Library" },
        //    new Libs { FirstName = "City", LastName = "Library" },
        //    new Libs { FirstName = "University ", LastName = "Library" }
        //);
        //context.Books.AddRange(
        //new Book { Name = "Crime and Punishment", Pages = 671, Id_Author = 7, YearPress = 1866, Id_Theme = 7, Id_Category = 4, Id_Press = 4, Comment = "Classic novel", Quantity = 5 },
        //new Book { Name = "One Hundred Years of Solitude", Pages = 417, Id_Author = 8, YearPress = 1967, Id_Theme = 8, Id_Category = 5, Id_Press = 5, Comment = "Masterpiece", Quantity = 3 },
        //new Book { Name = "Pride and Prejudice", Pages = 300, Id_Author = 9, YearPress = 1813, Id_Theme = 9, Id_Category = 6, Id_Press = 6, Comment = "Romantic classic", Quantity = 4 }
        //);
        //context.Departments.AddRange(
        //new Department { Name = "Mathematics" },
        //new Department { Name = "Physics" },
        //new Department { Name = "History" }
        //);
        //context.Teachers.AddRange(
        // new Teacher { FirstName = "Ali", LastName = "Məmmədov", Id_Department = 7 },
        // new Teacher { FirstName = "Leyla", LastName = "Həsənova", Id_Department = 8},
        // new Teacher { FirstName = "Rauf", LastName = "Quliyev", Id_Department = 9 }
        //);
        //context.Faculties.AddRange(
        //    new Faculty { Name = "Science" },
        //    new Faculty { Name = "Arts" },
        //    new Faculty { Name = "Engineering" }
        //);
        //context.Groups.AddRange(
        //new Group { Name = "FSDE24", Id_Faculty = 9 },
        //new Group { Name = "11B", Id_Faculty = 8 },
        //new Group { Name = "12C", Id_Faculty = 7 }
        //);
        //context.Students.AddRange(
        //new Student { FirstName = "Ayan", LastName = "Aliyeva", Id_Group = 5},
        //new Student { FirstName = "Omer", LastName = "Aliyev", Id_Group =  5},
        //new Student { FirstName = "Nigar", LastName = "Xelilova", Id_Group = 5 }
        //);
        //context.T_Cards.AddRange(
        //    new T_Card { Id_Teacher = 5, Id_Book = 6, Id_lib = 7, DateOut = DateTime.Now.AddDays(-5), DateIn = DateTime.Now.AddDays(5) },
        //    new T_Card { Id_Teacher = 6, Id_Book = 7, Id_lib = 8, DateOut = DateTime.Now.AddDays(-3), DateIn = DateTime.Now.AddDays(7) },
        //    new T_Card { Id_Teacher = 7, Id_Book = 8, Id_lib = 9, DateOut = DateTime.Now.AddDays(-1), DateIn = DateTime.Now.AddDays(14) }
        //);
        //context.S_Cards.AddRange(
        //    new S_Card { Id_Student = 5, Id_Book = 6, Id_lib = 7, DateOut = DateTime.Now.AddDays(-5), DateIn = DateTime.Now.AddDays(5) },
        //    new S_Card { Id_Student = 6, Id_Book = 7, Id_lib = 8, DateOut = DateTime.Now.AddDays(-3), DateIn = DateTime.Now.AddDays(7) },
        //    new S_Card { Id_Student = 7, Id_Book = 8, Id_lib = 9, DateOut = DateTime.Now.AddDays(-1), DateIn = DateTime.Now.AddDays(14) }
        //);
        //context.SaveChanges();

        await ShowBooksAsync(context);


    }
    public static async Task ShowBooksAsync(AppDbContext context)
    {
        var books = await context.Books.ToListAsync();
        var themes = await context.Themes.ToListAsync();
        var authors = await context.Authors.ToListAsync();
        Console.WriteLine($"{"Book name",-30} {"Author",-22} {"Book theme",-15} {"Year press"}");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        foreach (var book in books)
        {
            var theme = themes.FirstOrDefault(t => t.Id == book.Id_Theme);
            var author = authors.FirstOrDefault(a => a.Id == book.Id_Author);
            Console.WriteLine($"{book.Name,-30} {author.FirstName,-8} {author.LastName,-13} {theme?.Name,-15} {book.YearPress}");
        }
    }

    //public static async Task Show


}