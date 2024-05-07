// Convert to int
Console.WriteLine("Please enter your choice from the menu");
Console.WriteLine("Enter A for Add");
Console.WriteLine("Enter S for Subtract");
Console.WriteLine("Enter M for Multiply");
Console.WriteLine("Enter D for Divide");

string readResult = Console.ReadLine();


switch (readResult)
{
    case "A":
        Console.WriteLine("You want to Add");
        break;
    case "S":
        Console.WriteLine("You want to Subtract");
        break;
    case "M":
        Console.WriteLine("You want to Multiply");
        break;
    case "D":
        Console.WriteLine("You want to Divide");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
