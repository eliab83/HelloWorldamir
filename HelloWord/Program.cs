namespace HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! pleas enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("now enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("how old are you??");
            string age = Console.ReadLine();
            Console.WriteLine("you entered: " + firstName + lastName);
            Console.WriteLine("and you are " + age + " years old");
            Console.ReadKey();


        }
    }
}
