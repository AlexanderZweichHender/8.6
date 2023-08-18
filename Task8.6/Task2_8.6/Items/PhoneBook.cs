using Newtonsoft.Json;

namespace Task2_8._6.Items
{
    internal class PhoneBook
    {
        private Dictionary<string, string> _numbers
            = new Dictionary<string, string>();

        private readonly string _path;

        public PhoneBook(string path)
        {
            _path = path;

            if(!File.Exists(_path))
            {
                File.Create(_path);
                Console.WriteLine("File has been created");
            }
            else
            {
                try
                {
                    _numbers = DeserializeNumbers();
                }
                catch
                {
                    _numbers = new Dictionary<string, string>();
                }
            }
        }

        public void AddNumber()
        {
            Console.Write("Enter number: ");
            var number = Console.ReadLine();

            Console.Write("Enter name: ");
            var name = Console.ReadLine();

            _numbers.Add(number, name);
            SerializeNumbers();
        }

        public void SerializeNumbers()
        {
            var data = JsonConvert.SerializeObject(_numbers);
            File.WriteAllText(_path, data);
        }

        public Dictionary<string, string> DeserializeNumbers()
        {
            var data = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
        }

        public void ShowContactByNumber()
        {
            Console.Write("Enter number to find: ");
            var number = Console.ReadLine();

            Console.WriteLine(_numbers.FirstOrDefault(contact =>
                contact.Key == number));
        }

        public void RemoveContact()
        {
            Console.Write("Enter contact to remove: ");
            var key = Console.ReadLine();

            _numbers = _numbers.Where(number => number.Key != key && number.Value != key)
                .ToDictionary(number => number.Key, x => x.Value);
            SerializeNumbers();
        }
        public void ShowNumbers()
            => _numbers.ToList().ForEach(number => Console.WriteLine(number));
    }
}
