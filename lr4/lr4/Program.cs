using System;

namespace BookLibrary
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publisher;
        public int YearPublished;
        public int Pages;
        public double Price;
        public bool IsAvailable;
        public Book(string title, string author, string publisher, int yearPublished, int pages, double price, bool isAvailable)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            YearPublished = yearPublished;
            Pages = pages;
            Price = price;
            IsAvailable = isAvailable;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("Назва: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Видавництво: " + Publisher);
            Console.WriteLine("Рік публікації: " + YearPublished);
            Console.WriteLine("Кількість сторінок: " + Pages);
            Console.WriteLine("Ціна: " + Price.ToString("0.00"));
            Console.WriteLine(IsAvailable ? "Доступна" : "Не доступна");
            double pricePerPage = Price / Pages;
            Console.WriteLine("Середня ціна за сторінку: " + pricePerPage.ToString("0.00"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть інформацію про книгу:");
            Console.Write("Назва: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Видавництво: ");
            string publisher = Console.ReadLine();
            Console.Write("Рік публікації: ");
            int yearPublished = int.Parse(Console.ReadLine());
            Console.Write("Кількість сторінок: ");
            int pages = int.Parse(Console.ReadLine());
            Console.Write("Ціна: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Доступна? (так/ні): ");
            bool isAvailable = Console.ReadLine().ToLower() == "так";

            Book myBook = new Book(title, author, publisher, yearPublished, pages, price, isAvailable);
            Console.WriteLine("\nІнформація про книгу:");
            myBook.PrintBookInfo();
        }
    }
}
