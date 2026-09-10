using System.Runtime.CompilerServices;

Random random = new();

int a = random.Next(1, 10);

int b = random.Next(1, 10);

Console.Write($"{a} - {b} = ");
int ans = int.Parse(Console.ReadLine());

// ? this thing below is to make it so it never ends up a negative number
if (a > b)
{
    (a, b) = (b, a);
}

int correctAns = a - b;

if (ans == correctAns)
{
    Console.WriteLine($"That's correct!");
}

else
{
    Console.WriteLine($"Oof! Try again! The answer was: {correctAns}.");
}
