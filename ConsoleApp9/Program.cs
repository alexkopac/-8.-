using System;
using System.Linq;


namespace LambdaExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Func<int[], int, int> countMult = (arr, n) => arr.Count(x => x % n == 0);

            int[] numMult = { 1, 7, 14, 3, 21, 8, 49, 10 };
            int multOf = 7;
            int count7 = countMult(numMult, multOf);
            Console.WriteLine($"Кількість чисел, кратних {multOf}: {count7}");

            int multOf3 = 3;
            int count3 = countMult(numMult, multOf3);
            Console.WriteLine($"Кількість чисел, кратних {multOf3}: {count3}");

            Console.WriteLine();

           
            Func<int[], int, int, int> countInRange = (arr, min, max) => arr.Count(x => x >= min && x <= max);

            int[] numRange = { -5, 2, 8, -1, 5, 10, -3, 7 };

            int minPosit = 1;
            int maxPosit = int.MaxValue;
            int positCount = countInRange(numRange, minPosit, maxPosit);
            Console.WriteLine($"Кількість додатних чисел: {positCount}");

            int minRange = -4;
            int maxRange = 6;
            int rangeCount = countInRange(numRange, minRange, maxRange);
            Console.WriteLine($"Кількість чисел у діапазоні від {minRange} до {maxRange}: {rangeCount}");

            Console.ReadKey();
        }
    }
}