// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Silk.NET.Core;

for (var fps = 60; fps < 61440; fps *= 2)
{
    var sleep = new BreakneckSleep(TimeSpan.FromSeconds(1 / (double)fps));
    for (var t = 0; t < 5; t++)
    {
        var now = Stopwatch.GetTimestamp();
        sleep.Sleep();
        Console.WriteLine
            ($"{fps} FPS = {1 / Stopwatch.GetElapsedTime(now, Stopwatch.GetTimestamp()).TotalSeconds} FPS");
    }
}
