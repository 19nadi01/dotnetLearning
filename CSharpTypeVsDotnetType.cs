using System;

namespace CSharpLearning
{
    public class CSharpTypesVsDotnetTypes
    {
        // C# - types:
        byte b1 = 1;
        short sh1 = 11;
        int i1 = 12; 
        long l1 = 13;

        float f1 = 1.1f;
        double d1 = 2.2;
        decimal dc1 = 3.3m;

        bool bln1 = true;
        char ch1 = 'a';
        string s1 = "Name1";

        // .NET types:
        Byte b2 = 1;
        Int16 sh2 = 11;
        Int32 i2 = 12;
        Int64 l2 = 13;
        Int128 n = 14;

        Single f2 = 1.1f;
        Double d2 = 2.2;
        Decimal dc2 = 3.3m;

        Boolean bln2 = true;
        Char ch2 = 'a';
        String s2 = "Name1";

        public static void getNumberTypesRange()
        {
            Console.WriteLine("C#/.NET number types range");
            Console.WriteLine($"byte/Byte: min {byte.MinValue}, max {byte.MaxValue}");
            Console.WriteLine($"short/Int16: min {short.MinValue}, max {short.MaxValue}");
            Console.WriteLine($"int/Int32: min {int.MinValue}, max {int.MaxValue}");
            Console.WriteLine($"long/Int64: min {long.MinValue}, max {long.MaxValue}");
            Console.WriteLine($"Int128: min {Int128.MinValue}, max {Int128.MaxValue}");
            Console.WriteLine($"float/Single: min {float.MinValue}, max {float.MaxValue}");
            Console.WriteLine($"double/Double: min {double.MinValue}, max {double.MaxValue}");
            Console.WriteLine($"decimal/Decimal: min {decimal.MinValue}, max {decimal.MaxValue}");
        }
    }
}
