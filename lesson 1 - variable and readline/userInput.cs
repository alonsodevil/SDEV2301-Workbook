// prompt for name

Console.Write("Name: ");

// read the user input (always a string unless parsed)
string name = Console.ReadLine();

// print some message
Console.WriteLine($"Hello, {name}");

Console.Write("Hours: ");

string input = Console.ReadLine() ?? "";

double hours = double.Parse(input);

// Chad nested statements version
// double hours = double.Parse(Console.WriteLine() ?? 0);

Console.WriteLine($"Hours entered: {hours}.");

