using Core.Models;
using DataAccess.ListAndMethods;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Product.inputString = Console.ReadLine();
                Product.isValidInput = int.TryParse(Product.inputString, out Product.inputNumber);
                if (Product.isValidInput)
                {
                    switch (Product.inputNumber)
                    {
                        case 0:
                            {

                            }return;
                        default:
                            {
                                Console.WriteLine("enter valid option!");
                            }break;
                    }
                }
            }
        }
    }
}
