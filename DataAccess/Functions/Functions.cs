using Core.Models;


namespace DataAccess.Functions
{
    public class Functions
    {
        private static List<Products> books = new List<Products>();
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
                books.Add(new Products(stringName, doublePrice, stringISBN));
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
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            Console.Write("please enter the name of book: ");
            string findName = Console.ReadLine();
            foreach (Products book in books)
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
        public static void ShowAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            int counter = 1;
            foreach (Products book in books)
            {

                Console.WriteLine("book {0} ===> name: {1}   price: {2}   isbn: {3}", counter, book.Name, book.Price, book.ISBN);
                counter++;
            }


            Console.ReadKey();
        }
        public static void RemoveByISBN()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            Console.Write("enter isbn of book: ");
            string removeISBN = Console.ReadLine();
            foreach (Products book in books)
            {
                if (book.ISBN == removeISBN)
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
        public static void ShowExpensive()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            Products mostExpensive = books[0];
            foreach (Products book in books)
            {
                if (book.Price > mostExpensive.Price)
                {
                    mostExpensive = book;
                }
            }
            Console.WriteLine("the most expensive book name is {0}:", mostExpensive.Name);
            Console.ReadKey();
        }
        public static void ShowCheapest()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            Products cheapest = books[0];
            foreach (Products book in books)
            {
                if (book.Price < cheapest.Price)
                {
                    cheapest = book;
                }
            }
            Console.WriteLine("the most expensive book name is: {0}", cheapest.Name);
            Console.ReadKey();
        }
        public static void ShowCountBooks()
        {
            Console.WriteLine("the count of your books is: {0}", books.Count);
            Console.ReadKey();
        }
        public static void SortByPrice()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("the list is empty!");
                Console.ReadKey();
                return;
            }
            List<Products> sortedList = new List<Products>();
            foreach (Products book in books)
            {
                sortedList.Add(book);
            }
            for (int i = 0; i < sortedList.Count - 1; i++)
            {
                for (int j = 0; j < sortedList.Count - 1 - i; j++)
                {
                    if (sortedList[j].Price > sortedList[j + 1].Price)
                    {
                        Products temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }
            int counter = 1;
            foreach (Products book in sortedList)
            {
                Console.WriteLine("book {0} ===> name: {1}   price: {2}   isbn: {3}", counter, book.Name, book.Price, book.ISBN);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
