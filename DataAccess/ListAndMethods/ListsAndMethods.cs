using Core.Models;

namespace DataAccess.ListAndMethods
{
    public class ListsAndMethods
    {
        static List<Product> books = new List<Product>();
        public static void SetMenu()
        {
            Console.Clear();
            Console.WriteLine("PRESS(1)------Add New Book");
            Console.WriteLine("PRESS(2)------Search the books by name and show details");
            Console.WriteLine("PRESS(3)------Show all the books");
            Console.WriteLine("PRESS(4)------Remove the books by ISBN");
            Console.WriteLine("PRESS(5)------Show the most expensive book");
            Console.WriteLine("PRESS(6)------Show the cheapest book");
            Console.WriteLine("PRESS(7)------Show number of books");
            Console.WriteLine("PRESS(8)------Show the books by price(Sort by price)");
            Console.WriteLine("PRESS(9)------Show the books between two prices");
            Console.WriteLine("PRESS(0)------Exit");
            Console.Write("Please Enter a Number: ");
        }
        public static void AddBook()
        {
            Console.Write("Enter Name : ");
            string stringName = Console.ReadLine();
            Console.Write("Enter price : ");
            string stringPrice = Console.ReadLine();
            Console.Write("Enter isbn : ");
            string stringISBN = Console.ReadLine();
            if (double.TryParse(stringPrice, out double doublePrice))
            {
                books.Add(new Product(stringName, doublePrice, stringISBN));
                Console.WriteLine("the book succesfully added!");
            }
            else
            {
                Console.WriteLine("please enter valid book!");
            }
            Console.ReadKey();
        }
        public static void FindBook()
        {
            Console.Write("please enter the name of book : ");
            string findName = Console.ReadLine();
            if (books.Count > 0)
            {
                foreach (Product book in books)
                {
                    if (book.Name == findName)
                    {
                        Console.WriteLine("name {0}, price {1}, isbn {2}", book.Name, book.Price, book.ISBN);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("this name not available!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("the list is empty!");
            }
            Console.ReadKey();
        }
        public static void ShowAllBooks()
        {
            if (books.Count > 0)
            {
                int counter = 1;
                foreach (Product book in books)
                {

                    Console.WriteLine("book {0} ===> name: {1}   price: {2}   isbn: {3}", counter, book.Name, book.Price, book.ISBN);
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("the list is empty!");
            }
            Console.ReadKey();
        }
        public static void RemoveByISBN()
        {
            if (books.Count > 0)
            {
                Console.Write("enter isbn of book: ");
                string removeISBN = Console.ReadLine();
                foreach (Product book in books)
                {
                    if (book._ISBN == removeISBN)
                    {
                        books.Remove(book);
                        Console.WriteLine("the book removed!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("this isbn not available!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("the list is empty!");
            }
            Console.ReadKey();
        }
    }
}
