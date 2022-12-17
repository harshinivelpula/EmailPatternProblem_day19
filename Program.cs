namespace EmailPatternProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            emailpattern emailPattern = new emailpattern();
            Console.WriteLine("enter the email");
            string email = Console.ReadLine();
            bool value = emailPattern.validemail(email);
            if (value)
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("not matched");
            }
        }
    }
}