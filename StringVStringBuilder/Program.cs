using System.Diagnostics;
using System.Text;

const int max = 100000;
WriteTimeSpanOfString(); // 83s
WriteTimeSpanOfStringBuilder(); //00s

static void WriteTimeSpanOfString()
{
    Console.WriteLine($"String: appending {max} times");

    Stopwatch stopwatch = new();
    string text = "s";
    stopwatch.Start();
    for (int i = 0; i < max; i++) text += i;
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}
static void WriteTimeSpanOfStringBuilder()
{
    Console.WriteLine($"StringBuilder: appending {max} times");

    Stopwatch stopwatch = new();
    StringBuilder text = new("b");
    stopwatch.Start();
    for (int i = 0; i < max; i++) text.Append(i);
    stopwatch.Stop();

    Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
}