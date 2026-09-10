Random random = new();

int a = random.Next(1, 10);

int b = random.Next(1, 10);

if (a > b)
{
    (a, b) = (b, a);
}

int correctAnswer = a - b;

Console.Write($"{a} - {b} = ");

int answer = int.Parse(Console.ReadLine() ?? "");

while (answer != correctAnswer)
{
    Console.WriteLine("Oops! Try again!");
    Console.Write($"{a} - {b} = ");
    answer = int.Parse(Console.ReadLine() ?? "");
}

if (answer == correctAnswer)
{
    Console.WriteLine("Correct!");
}