using ImportantApp.HardMath;
using ImportantApp.SimpleMath;

namespace ImportantApp.ConsoleApp;

class Program
{
    static void Main()
    {
        var hm = new HardMaths();
        var multiplicationResult = hm.DecimalMultiplication(1M, 2M);
        Console.WriteLine($"Multiplication result is: {multiplicationResult}");

        var sm = new SimpleMaths();
        var additionResult = sm.DecimalAddition(1M, 2M);
        Console.WriteLine($"Addition result is: {additionResult}");
    }
}
