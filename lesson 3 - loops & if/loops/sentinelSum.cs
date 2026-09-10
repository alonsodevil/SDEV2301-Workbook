Console.Write("Enter a FREAKY number: ");
int value = int.Parse(Console.ReadLine() ?? "");

int sum = 0;

while (value != 0)
{
    sum += value;

    Console.Write("More FREAKY numbers (enter 0 to exit): ");
    value = int.Parse(Console.ReadLine() ?? "");
}

Console.WriteLine($"Your high score is: {sum}.");