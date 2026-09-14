static void PrintSum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"{a} + {b} = {sum}");
}

static int Add(int a, int b)
{
    return a + b;
}

PrintSum(8, 5);

int result = Add(8, 5) * 2;

Console.WriteLine($"Result from Add() method: (8 + 5) * 2 = {result}");