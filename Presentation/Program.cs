using DataAccess.Functions;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Functions.SetMenu();
                string stringMenu = Console.ReadLine();
                bool isValidInput = int.TryParse(stringMenu, out int intMenu);
                if (isValidInput && intMenu > 0 && intMenu <= 9)
                {
                    switch (intMenu)
                    {
                        case 1:
                            {
                                Functions.AddBook();
                            }
                            break;
                        case 2:
                            {
                                Functions.FindBook();
                            }
                            break;
                        case 3:
                            {
                                Functions.ShowAllBooks();
                            }break;
                        case 4:
                            {
                                Functions.RemoveByISBN();
                            }break;
                        case 5:
                            {
                                Functions.ShowExpensive();
                            }break;
                        case 6:
                            {
                                Functions.ShowCheapest();
                            }break;
                        case 7:
                            {
                                Functions.ShowCountBooks();
                            }break;
                        case 8:
                            {
                                Functions.SortByPrice();
                            }break;
                        case 9:
                            {
                                Functions.ShowBooksBetweenTwoPrice();
                            }break;
                    }
                }
                else if (isValidInput && intMenu == 0)
                {
                    Console.WriteLine("!!!!!!the program ended!!!!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("please enter valid menu!");
                    Console.ReadKey();
                }
            }
        }
    }
}
