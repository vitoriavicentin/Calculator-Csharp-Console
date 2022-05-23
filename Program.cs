
public class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the Calculator!! \nChoose the operation you want to use:");
        Console.WriteLine("1 -  Sum");
        Console.WriteLine("2 -  Subtraction");
        Console.WriteLine("3 -  Division");
        Console.WriteLine("4 -  Multiplication");
        Console.WriteLine("5 -  Exit");
        Console.WriteLine("\n\nSelect you operation:");

        short.TryParse(Console.ReadLine(), out short res);

        switch (res)
        {
            case 1:
                Sum();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Division();
                break;
            case 4:
                Multiplication();
                break;
            case 5:
                System.Environment.Exit(0);
                break;
            default:
                Menu();
                break;
        }
    }
    static void Sum()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float.TryParse(Console.ReadLine(), out float firstValue);

        Console.WriteLine("Second value: ");
        float.TryParse(Console.ReadLine(), out float secondValue);

        float result = (firstValue + secondValue);
        Console.WriteLine($"\nThe sum result is: {result.ToString()}");
        Console.ReadKey();
        Menu();
    }

    static void Subtraction()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float.TryParse(Console.ReadLine(), out float firstValue);

        Console.WriteLine("Second value: ");
        float.TryParse(Console.ReadLine(), out float secondValue);

        float result = (firstValue - secondValue);
        Console.WriteLine($"\nThe result subtraction is: {result.ToString()}");
        Console.ReadKey();
        Menu();
    }

    static void Division()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float.TryParse(Console.ReadLine(), out float firstValue);

        Console.WriteLine("Second value: ");
        float.TryParse(Console.ReadLine(), out float secondValue);

        if (firstValue > 0 && secondValue > 0)
        {
            float result = (firstValue / secondValue);
            Console.WriteLine($"\nThe result division is: {result.ToString()}");
        }
        else
        {
            Console.WriteLine($"\nValues must be greater than 0");
        }
        Console.ReadKey();
        Menu();
    }

    static void Multiplication()
    {
        Console.Clear();

        Console.WriteLine("First value: ");
        float.TryParse(Console.ReadLine(), out float firstValue);

        Console.WriteLine("Second value: ");
        float.TryParse(Console.ReadLine(), out float secondValue);

        float result = (firstValue * secondValue);
        Console.WriteLine($"\nThe result multiplication is: {result.ToString()}");
        Console.ReadKey();
        Menu();
    }

}
