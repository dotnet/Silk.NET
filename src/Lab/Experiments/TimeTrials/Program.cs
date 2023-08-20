// See https://aka.ms/new-console-template for more information

using System.Collections.Concurrent;
using System.Diagnostics;
using Silk.NET.Core;
using Silk.NET.Windowing;

var timeWindow = new TimeWindow();
var bag = new ConcurrentBag<double>();
var sw = new Stopwatch();
Console.Write("Enter frames per second: ");
timeWindow.Window = TimeSpan.FromSeconds(1 / double.Parse(Console.ReadLine()!));
Console.Write("Open a window? (Y/N) ");
ConsoleKey k;
while ((k = Console.ReadKey().Key) is not ConsoleKey.Y and not ConsoleKey.Y) {}

if (k == ConsoleKey.Y)
{
    Console.Write("\nOpening window...\n");
    var realWindow = Window.Create
    (
        WindowOptions.Default with
        {
            VSync = false, FramesPerSecond = 1 / timeWindow.Window.TotalSeconds,
            UpdatesPerSecond = 1 / timeWindow.Window.TotalSeconds
        }
    );
    realWindow.Initialize();
    realWindow.Title += " | 0 FPS | 0 UPS";
    realWindow.Render += d =>
    {
        var cur = realWindow.Title;
        realWindow.Title = cur.Replace
            (cur[cur.IndexOf('|')..(cur.IndexOf(" FPS", StringComparison.Ordinal) + 4)], $"| {1 / d:0000.000} FPS");
        Console.WriteLine($"{sw.Elapsed.TotalSeconds},{d}");
    };
    realWindow.Update += d =>
    {
        var cur = realWindow.Title;
        realWindow.Title = cur.Replace
            (cur[cur.LastIndexOf('|')..(cur.IndexOf(" UPS", StringComparison.Ordinal) + 4)], $"| {1 / d:0000.000} UPS");
    };
    Console.WriteLine("Recording Time,Frame Time");
    sw.Start();
    while (!realWindow.IsClosing)
    {
        if (timeWindow.BeginWindow())
        {
            if (!realWindow.IsClosing)
            {
                realWindow.DoUpdate();
            }

            if (!realWindow.IsClosing)
            {
                realWindow.DoRender();
            }
            timeWindow.EndWindow();
        }
        realWindow.DoEvents();
    }

    realWindow.DoEvents();
    realWindow.Reset();
    return;
}

Console.WriteLine("Press Ctrl+C to measure statistics.");
Console.CancelKeyPress += (_, _) =>
{
    var overshoots = bag.ToList();
    var count = overshoots.Count;
    sw.Stop();
    Console.WriteLine($"Run time: {sw.Elapsed.TotalSeconds}");
    Console.WriteLine($"Frames: {overshoots.Count}");
    Console.WriteLine($"Expected Frames: {sw.Elapsed.TotalSeconds / timeWindow.Window.TotalSeconds}");
    Console.WriteLine($"Overshoots: {overshoots.Count(x => x > 0)}");
    Console.WriteLine($"Undershoots: {overshoots.Count(x => x < 0)}");
    Console.WriteLine($"Max overshoot: {overshoots.Max()}");
    Console.WriteLine($"Max undershoot: {overshoots.Min()}");
    Console.WriteLine($"Mean overshoot/undershoot: {overshoots.Sum() / overshoots.Count}");
    Console.WriteLine($"Median overshoot/undershoot: {overshoots.Order().ElementAt(overshoots.Count / 2)}");
    Console.WriteLine($"Overshoot/undershoot range: {overshoots.Max() - overshoots.Min()}");
    overshoots.RemoveAll(x => x < 0);
    Console.WriteLine($"Min overshoot/wasted time per frame: {overshoots.Min()}");
    Console.WriteLine($"Mean wasted time per frame: {overshoots.Sum() / overshoots.Count}");
    Console.WriteLine($"Median wasted time per frame: {overshoots.Order().ElementAt(overshoots.Count / 2)}");
    Console.WriteLine($"Range for wasted time per frame: {overshoots.Max() - overshoots.Min()}");
    Console.WriteLine($"Final FPS: {1 / (sw.Elapsed.TotalSeconds / count)}");
};
sw.Start();
while (true)
{
    if (timeWindow.BeginWindow())
    {
        bag.Add((timeWindow.CurrentTime - timeWindow.NextWindowStart).TotalSeconds);
        timeWindow.EndWindow();
    }
    else
    {
        bag.Add(-(timeWindow.NextWindowStart - timeWindow.CurrentTime).TotalSeconds);
    }
}
