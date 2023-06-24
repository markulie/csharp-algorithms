using System.Diagnostics;
using System.Text;

const int max = 100000;
StringConcat(); // 83s
StringConcatMethod(); // 83s
StringBuilderAppend(); //00s

static void StringConcat()
{
    Console.WriteLine($"String+String {max} times");

    Stopwatch stopwatch = new();
    string text = "s";
    stopwatch.Start();
    for (int i = 0; i < max; i++) text += i;
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}
static void StringConcatMethod()
{
    Console.WriteLine($"String.Concat() {max} times");

    Stopwatch stopwatch = new();
    string text = "s";
    stopwatch.Start();
    for (int i = 0; i < max; i++) text = string.Concat(text, i);
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}
static void StringBuilderAppend()
{
    Console.WriteLine($"StringBuilder.Append() {max} times");

    Stopwatch stopwatch = new();
    StringBuilder text = new("b");
    stopwatch.Start();
    for (int i = 0; i < max; i++) text.Append(i);
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}