
    
    Console.Write("Enter the hourly rate: ");

    decimal hourRate = decimal.Parse(Console.ReadLine());

    Console.Write("Enter the hours worked: ");
    decimal hourWorked = decimal.Parse(Console.ReadLine());

    decimal pay = hourRate * hourWorked;

    Console.WriteLine($"Your pay is {pay:C}");
