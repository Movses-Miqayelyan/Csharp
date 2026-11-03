namespace ConsoleApp4;
using System;

delegate int Op(int a);

class Program {
    static int Double(int x){
        return x *= 2;
    }
    static int PlusTen(int y){
        return y += 10;
    }
    static int Apply(int a, Op operation){
        return operation(a);
    }
        
    static void Main() {
        Op operation = Double ;
        Console.WriteLine(operation(5));
      
        operation = PlusTen;
        Console.WriteLine(operation(5));
      
        Console.WriteLine(Apply(5, Double));
        Console.WriteLine(Apply(0, Double));
        Console.WriteLine(Apply(5, PlusTen));
        Console.WriteLine(Apply(0, PlusTen));
    }
}



