while (true)
{
    Console.Write(">> Enter the name of a data type (e.g. int, float, double): ");
    string input = Console.ReadLine() ?? "";

    Dictionary<string, (int size, dynamic min, dynamic max)> types = new()
    {
        { "bool", (sizeof(bool), bool.FalseString, bool.TrueString) },
        { "byte", (sizeof(byte), byte.MinValue, byte.MaxValue) },
        { "sbyte", (sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue) },
        { "char", (sizeof(char), char.MinValue, char.MaxValue) },
        { "short", (sizeof(short), short.MinValue, short.MaxValue) },
        { "ushort", (sizeof(ushort), ushort.MinValue, ushort.MaxValue) },
        { "int", (sizeof(int), int.MinValue, int.MaxValue) },
        { "uint", (sizeof(uint), uint.MinValue, uint.MaxValue) },
        { "long", (sizeof(long), long.MinValue, long.MaxValue) },
        { "ulong", (sizeof(ulong), ulong.MinValue, ulong.MaxValue) },
        { "float", (sizeof(float), float.MinValue, float.MaxValue) },
        { "double", (sizeof(double), double.MinValue, double.MaxValue) },
        { "decimal", (sizeof(decimal), decimal.MinValue, decimal.MaxValue) }
    };

    if (types.ContainsKey(input))
    {
        (int size, dynamic min, dynamic max) = types[input];
        Console.WriteLine($"Memory size: {size} bytes\nMinimum value: {min}\nMaximum value: {max}");
    }
    else
    {
        Console.WriteLine("Invalid data type name.");
    }
}