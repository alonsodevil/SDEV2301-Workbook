
namespace HelloWorldConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, Visual studio world!");

            Console.Write("Enter the greatest thing ever: ");

            //int count = 5;        This doesn't work on c#

            //count = "ten";

            var age = 20;

            string name = "Alonso";

            decimal money = 400;

            double num = 2.3;

            bool flagForHungry = true;

            Console.WriteLine(age);

            Console.WriteLine(name);

            Console.WriteLine(money);

            Console.WriteLine(num);

            Console.WriteLine(flagForHungry);

            double answer = 5 / 2;
            double benswer = 5.0 / 2;
            double remainder = 5 % 2;

            Console.WriteLine(answer);
            Console.WriteLine(benswer);
            Console.WriteLine(remainder);

            string name2 = "Mike";
            int score = 74;

            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"Score: {score}");

            Console.Write("What is the greatest thing human?: ");
            string greatThing = Console.ReadLine();

            Console.WriteLine($"Very good, \"{greatThing}\"... very very interesting... ");

            Console.Write("What is the worst number?: ");
            int worstNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"Very good, \"{worstNum}\"... the worst of the worst... ");

        }
    }
}