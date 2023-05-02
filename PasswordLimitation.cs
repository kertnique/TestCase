namespace TestCase
{
    public class PasswordLimitation
    {
        public int min = 0;
        public int max = 0;
        public char charCheck = 'A';
        public string sourcePass = "";

        public PasswordLimitation(int mn, int mx, char check, string password)
        {
            min = mn;
            max = mx;
            charCheck = check;
            sourcePass = password;
        }

        public bool Check()
        {
            int occurences = sourcePass.Count(a => a == charCheck);
            if (min <= occurences && occurences <= max) return true;
            return false;
        }
    }
}