global using ConsoleAppCSharp10.Models;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ConsoleAppCSharp10;
using ConsoleAppCSharp10.InterpolatedStringHandlerAttributes;

void Example2()
{
    var rp1 = new RecordStructPerson();
    Console.WriteLine($"rp1.FirstName: {rp1.FirstName}");
    Console.WriteLine($"rp1.LastName: {rp1.LastName}");
    var rp2 = new RecordStructPerson("ilkay", "kabas");
    Console.WriteLine($"rp2.FirstName: {rp2.FirstName}");
    Console.WriteLine($"rp2.LastName: {rp2.LastName}");
}

void Example3()
{
    var rp1 = new RecordStructPerson("ilkay", "kabas");
    Console.WriteLine($"ToString(): {rp1}");
}

void Example5()
{
    var person = new PersonModel()
    {
        FirstName = "ilkay",
        LastName = "kabas",
        Department = new DepartmentModel()
        {
            Id = "1",
            Name = "department 1"
        }
    };

    if (person is PersonModel {Department: {Name: "department 1"}})
    {
        Console.WriteLine("(C#9) department is department 1");
    }

    if (person is PersonModel {Department.Name: "department 1"})
    {
        Console.WriteLine("(C#10) department is department 1");
    }

    if (person is PersonModel {Department: {Name: "department 2"}})
    {
        Console.WriteLine("department is department 2");
    }
}

void Example8()
{
    var parse = (string s) => int.Parse(s);
    Expression<Func<PersonModel, bool>> expression = e => e.FirstName == "ilkay";
}

void Example9()
{
    double a = 4;
    double b = 5;
    ExampleInterpolatedStringHandlerMethod($"Dikdortgenin alani: a: {a} b: {b} sonuc: {a * b}");
}

void ExampleInterpolatedStringHandlerMethod(ExampleInterpolatedStringHandler stringHandler)
{
    Console.WriteLine(stringHandler.ToString());
}

[Obsolete($"Call {nameof(PersonModel)}")]
void Example10()
{
    const string rootPath = "C:\\Users\\hb\\src";
    const string filePath = $"{rootPath}\\README.md";
}

void Example12(bool condition, [CallerArgumentExpression("condition")] string? conditionExpression = null)
{
    Console.WriteLine($"The condition failed: {conditionExpression}");
}

void Example13()
{
    int x2;
    int y2;
    (x2, y2) = (0, 1);       // Works in C# 9
    (var x, var y) = (0, 1); // Works in C# 9
    (x2, var y3) = (0, 1);   // Works in C# 10 onwards
}

void Example14(object value)
{
    ArgumentNullException.ThrowIfNull(value);
}

Console.WriteLine("Example2");
Example2();
Console.WriteLine("--------");
Console.WriteLine("Example3");
Example3();
Console.WriteLine("--------");
Console.WriteLine("Example5");
Example5();
Console.WriteLine("--------");
Console.WriteLine("Example9");
Example9();
Console.WriteLine("--------");
Console.WriteLine("Example12");
Example12(true);
Example12(false);
Example12(3 > 23);
Console.WriteLine("--------");