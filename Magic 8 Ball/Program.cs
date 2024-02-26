namespace Magic_8_Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question();
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
            Console.WriteLine("Question: " + question + "\n\nAnswer: " + "hello");
        }
    }
}
