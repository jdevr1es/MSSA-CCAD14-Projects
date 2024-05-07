// Program to calculate on two integers

using System.Runtime.InteropServices;

namespace MyNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            do
            {
                Console.WriteLine("Please enter your choice from the menu");
                Console.WriteLine("Enter A for Add");
                Console.WriteLine("Enter S for Subtract");
                Console.WriteLine("Enter M for Multiply");
                Console.WriteLine("Enter D for Divide");
                Console.WriteLine("Enter X to exit program");

                readResult = Console.ReadLine();


                switch (readResult)
                {
                    case "A":
                    case "a":
                        AddMethod();
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
                    case "X":
                    case "x":
                        Console.WriteLine("You want to exit");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while ( readResult != "x" && readResult != "X");
        }



        static void AddMethod()
        {
            Console.WriteLine("Please enter to integers");
            Console.WriteLine("Enter integer 1:");
            int readResult1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer 2:");
            int readResult2 = Convert.ToInt32(Console.ReadLine());
            int sum = readResult1 + readResult2;
            Console.WriteLine();
            Console.WriteLine("The answer is " + sum);
        }

    }
}
