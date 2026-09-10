Console.Write("Enter the team size (1 - 15): ");

int teamSize = int.Parse(Console.ReadLine() ?? "");

while (teamSize < 0 || teamSize > 15)
{
    Console.WriteLine("Hmmmm... it's out of range.");
    Console.Write("Try again: ");
    teamSize = int.Parse(Console.ReadLine() ?? "");
}