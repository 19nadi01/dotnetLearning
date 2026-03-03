using System;

namespace CSharpLearning;

public class Program
{
    public static void Main(string[] args)
    {
        // after that method is called the variable 'number' will be assigned a value and can be used
        getNumber(out int number);
        Console.WriteLine($"out: {number}");
        Console.WriteLine();

        Console.WriteLine(StaticClass.Number);
        StaticClass.IncrementNumber();
        Console.WriteLine(StaticClass.Number);

        string newName = StaticClass.GetName();
        Console.WriteLine(newName);
        StaticClass.SetName("Ek");
        Console.WriteLine(StaticClass.GetName());

        NonStaticClassWithStatichMembers.ModifyNameStaticMethod();
        Console.WriteLine(NonStaticClassWithStatichMembers.GetStaticName());

        var nonStatic = new NonStaticClassWithStatichMembers();
        nonStatic.ModifyNamesInstanceMethod();
        Console.WriteLine(nonStatic.GetInstanceName());
        Console.WriteLine(nonStatic.GetStaticNameByInstanceMethod());

    }

    // out key word will give data back to the caller as a variable with the name 'number' without using return
    public static void getNumber(out int number)
    {
        number = 13;
    }


}
