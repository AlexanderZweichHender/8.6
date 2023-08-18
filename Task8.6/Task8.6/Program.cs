namespace Solution
{
    internal class Program
    {
        private static readonly Random _random = new Random();

        private static void Main()
        {
            var numbers = FillList();

            Console.WriteLine("Default list:");
            ShowList(numbers);

            numbers = ChangeList(numbers);

            Console.WriteLine("After refactoring:");
            ShowList(numbers);
        }

        private static List<int> FillList()
        {
            return Enumerable.Range(0, 100)
                .Select(number => _random.Next(0, 100))
                .ToList();
        }

        private static void ShowList(List<int> numbers)
               => numbers.ForEach(number => Console.WriteLine(number));

        private static List<int> ChangeList(List<int> numbers)
            => numbers = numbers.Where(numbers => numbers <= 25 || numbers >= 50).ToList();
    }
}
