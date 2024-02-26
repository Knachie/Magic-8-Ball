namespace Magic_8_Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Question();

                Console.WriteLine("\nPress escape to leave");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.Clear();
            }
        }

        static void Question()
        {
            Console.WriteLine("Enter your question?");
            string question = Console.ReadLine();

            Console.Clear();
            Console.Write("Fetching oracle");

            for(int i = 0; i < 3; i++)
            {
                Task.Delay(1000).Wait();
                Console.Write('.');
            }

            Task.Delay(1000).Wait();
            Console.Clear();
            Console.WriteLine("Question: " + question + "\n\nAnswer: " + Answer());
        }

        static string Answer()
        {
            string result = string.Empty;
            Random random = new Random();

            string[] answers = { "It is a possibility", "It is certain", "You may rely on it", "The chanses are slim", "Don't count on it", "My reply is no", "All signs point to yes" };
            result = answers[random.Next(answers.Length)];

            return result;
        }
    }
}
