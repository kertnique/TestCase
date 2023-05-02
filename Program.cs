namespace TestCase
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "input.txt";
            string sourceText = "";
            try
            {
                sourceText = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                throw new Exception(ExceptionMessages.noFile);
            }
            string[] lines = sourceText.Split('\n');
            int answer = 0;
            ParserToPasswordLimitation parser = new ParserToPasswordLimitation();
            foreach (string passwordCheck in lines)
            {
                if (parser.Parse(passwordCheck).Check()) answer++;
            }
            Console.Write(answer);
        }
    }
}