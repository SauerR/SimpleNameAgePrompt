namespace GiraffeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ini
            string name;
            string age;

            Console.Write("Enter your name: "); //Text to ask user their name
            name = Console.ReadLine(); //Allow user to enter their name

            Console.WriteLine("");

            Console.Write("Enter your age: "); //Text to ask user their age
            age = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}