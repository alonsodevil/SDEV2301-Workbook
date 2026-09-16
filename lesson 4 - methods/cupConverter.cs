class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResults(cups, ounces);
    }

    static double GetCups()
    {
        double cupNum;
        Console.Write("Enter the cup amount: ");
        // double cupNum = double.Parse(Console.ReadLine() ?? "");


        // if convertion fail, either inputted letter or lower than zero, go in loop, if success, store value in cupNum
        while (! double.TryParse(Console.ReadLine() ?? "", out cupNum) || cupNum < 0)
        {
            Console.Write("NO! Enter a value of cups number please: ");

        }
        return cupNum;
    }

    static double CupsToOunces(double cups)
    {
        return cups * 8;
    }
    
    static void DisplayResults(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups to ounces is: {ounces} oz");
    }
    
}