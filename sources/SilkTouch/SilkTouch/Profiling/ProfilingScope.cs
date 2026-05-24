// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Silk.NET.SilkTouch.Profiling;

/// <summary>
/// Lightweight way to profile a section of code.
/// </summary>
internal readonly struct ProfilingScope : IDisposable
{
    private readonly string _name;
    private readonly long _timestamp;

    public ProfilingScope(string name)
    {
        _name = name;
        _timestamp = Stopwatch.GetTimestamp();
    }

    public void Dispose()
    {
        var elapsed = Stopwatch.GetElapsedTime(_timestamp);
        Console.WriteLine(
            "Elapsed time for scope \"{0}\": {1:F3} ms",
            _name,
            elapsed.TotalMilliseconds
        );
    }
}
