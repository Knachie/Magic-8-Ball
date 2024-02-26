namespace Magic_8_Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        static string Answer()
        {
            string result = string.Empty;
            Random random = new Random();

            string[] answers = { "it is a possibility", "it is certain", "you may rely on it", "the chanses are slim", "don't count on it", "my reply is no", "all signs point to yes"};
            result = answers[random.Next(answers.Length)];

            return result;
        }
    }
}
