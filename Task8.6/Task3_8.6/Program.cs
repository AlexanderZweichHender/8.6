namespace Solution
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = new HashSet<int>();

            while(true)
            {
                try
                {
                    Console.Write("Enter number: ");
                    var input = int.Parse(Console.ReadLine());

                    if (numbers.Contains(input))
                    {
                        Console.WriteLine($"{input} is already exists");
                    }
                    else
                    {
                        numbers.Add(input);
                        numbers.ToList().ForEach(context => Console.WriteLine(context));
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input");
                }                        
            }
        }
    }
}