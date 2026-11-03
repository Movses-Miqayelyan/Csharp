namespace ConsoleApp4;


delegate int Op(int a);

class Program
{
    static int Double(int x)
    {
        return x *= 2;
    }

    static int PlusTen(int y)
    {
        return y += 10;
    }

    static void Main(string[] args)
    {
        Op operation = Double;
        Console.WriteLine(operation(4));
        Console.WriteLine(operation(7));

        operation = PlusTen;
        Console.WriteLine(operation(4));
        Console.WriteLine(operation(7));

    }
}




