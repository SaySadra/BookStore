using DataAccess.ListAndMethods;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ListsAndMethods.SetMenu();
                string stringMenu = Console.ReadLine();
                bool isValidInput = int.TryParse(stringMenu, out int intMenu);
                if (isValidInput && intMenu > 0 && intMenu <= 9)
                {
                    switch (intMenu)
                    {
                        case 1:
                            {
                                ListsAndMethods.AddBook();
                            }
                            break;
                        case 2:
                            {
                                ListsAndMethods.FindBook();
                            }
                            break;
                        case 3:
                            {
                                ListsAndMethods.ShowAllBooks();
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
