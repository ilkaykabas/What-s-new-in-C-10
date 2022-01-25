using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleAppCSharp10.InterpolatedStringHandlerAttributes;

[InterpolatedStringHandler]
public class ExampleInterpolatedStringHandler
{
    private readonly StringBuilder _builder;

    public ExampleInterpolatedStringHandler(int literalLength, int formattedCount)
    {
        _builder = new StringBuilder(literalLength);
        Console.WriteLine($"literalLength: {literalLength}     formattedCount: {formattedCount}");
    }

    public void AppendLiteral(string s)
    {
        _builder.Append(s);
        Console.WriteLine($"AppendLiteral called: {s}");
    }

    public void AppendFormatted<T>(T t)
    {
        _builder.Append(t?.ToString());
        Console.WriteLine($"AppendFormatted<T> called: {t} is of type: {typeof(T)}");
    }

    public override string ToString()
    {
        return _builder.ToString();
    }
}