namespace TestCase
{
    public class ParserToPasswordLimitation
    {
        public PasswordLimitation Parse(string source)
        {
            int min = 0, max = 0;
            string password = "";
            char charCheck = ' ';
            string[] arrayParse = source.Replace(":", String.Empty).Split(' ', '-');
            if (arrayParse.Length == 4)
            {
                if (arrayParse[0].ToString().Length != 1) throw new Exception(ExceptionMessages.badChar);
                charCheck = char.Parse(arrayParse[0]);
                password = arrayParse[3];
                try
                {
                    min = Convert.ToInt32(arrayParse[1]);
                    max = Convert.ToInt32(arrayParse[2]);
                    if (min > max) throw new Exception(ExceptionMessages.minGreaterThanMax);
                }
                catch (Exception)
                {
                    throw new Exception(ExceptionMessages.badInts);
                }
            }
            else throw new Exception(ExceptionMessages.badFormatting);
            return new PasswordLimitation(min, max, charCheck, password);
        }
    }
}