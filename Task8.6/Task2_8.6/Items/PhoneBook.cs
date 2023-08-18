using System.Text.Json;

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
                _numbers = DeserializeNumbers();
            }
        }

        public void SerializeNumbers()
        {
            using (var fileStream = new FileStream(_path, FileMode.Append, FileAccess.Write))
            {
                JsonSerializer.Serialize(fileStream, _numbers);
            }
        }

        public Dictionary<string, string> DeserializeNumbers()
        {
            using(var fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                return JsonSerializer.Deserialize<Dictionary<string, string>>(fileStream);
            }
        }

        public void ShowNumbers(Dictionary<string, string> numbers)
        {
            //numbers.For
        }
    }
}
