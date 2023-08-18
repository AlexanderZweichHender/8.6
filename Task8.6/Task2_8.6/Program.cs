using Task2_8._6.Items;

namespace Solution
{
    internal class Program
    {
        private static readonly string _path = "PhoneNumbers.txt";

        private static void Main()
        {
            var phoneBook = new PhoneBook(_path);

            while (true)
            {
                Console.Write("Enter operation number:\n0 - quit\n1 - show all numbers\n" +
                    "2 - add new number\n3 - find contact\n4 - remove contact\n");
                
                switch(Console.ReadLine())
                {
                    case "1":
                        phoneBook.ShowNumbers();
                        break;
                    case "2":
                        phoneBook.AddNumber();
                        break;
                    case "3":
                        phoneBook.ShowContactByNumber();
                        break;
                    case "4":
                        phoneBook.RemoveContact();
                        break;                       
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }           
        }
    }
}