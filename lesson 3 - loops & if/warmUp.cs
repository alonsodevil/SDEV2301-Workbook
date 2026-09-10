using static System.Console;  // allows to access all static methods in console class 

// prompt and read in age

Write("What is your age?: ");
string input = ReadLine() ?? 0;

int age = int.Parse(input);

if (age >= 10)
{
    WriteLine("You are an Adult");
}

else
{
    WriteLine("You are a wee baby human.");
}