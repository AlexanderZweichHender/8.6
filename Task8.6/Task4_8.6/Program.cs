using System.Xml.Serialization;
using Task4_8._6.Items;

namespace Solution
{
    internal class Program
    {
        private static readonly string _path = "Contact.txt";

        private static void Main()
        {
            Console.Write("Enter contact name: ");
            var name = Console.ReadLine();

            Console.Write("Enter street: ");
            var street = Console.ReadLine();

            Console.Write("Enter house number: ");
            var houseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter flat number: ");
            var flatNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter mobile phone number: ");
            var mobileNumber = Console.ReadLine();

            Console.Write("Enter home phone number: ");
            var homePhoneNumber = Console.ReadLine();

            var contact = new Contact(name, street, houseNumber, 
                flatNumber, mobileNumber, homePhoneNumber);

            var xmlSerializer = new XmlSerializer(typeof(Contact));
            
            using (var fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStream, contact);
            }
        }
    }
}