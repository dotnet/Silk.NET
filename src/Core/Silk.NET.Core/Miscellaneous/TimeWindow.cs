// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Core;

/// <summary>
/// Represents a window/interval of time in which the caller can execute.
/// </summary>
/// <example>
/// To create a 60 FPS loop:
/// <code>
/// var window = new TimeWindow();
/// window.Window = TimeSpan.FromSeconds(1.0 / 60.0);
/// while (true)
/// {
///     if (window.BeginWindow())
///     {
///         // It's time for the next piece of work (e.g. rendering the next frame)
///         window.EndWindow(); // don't forget this!
///     }
///     // Anything that isn't necessarily dependent on a time window goes here.
///     // In most cases, BeginWindow will sleep and always return true. This is not guaranteed, however, so anything
///     // "real-time" (e.g. event processing) should be done here.
/// }
/// </code>
/// </example>
public class TimeWindow
{
#if NET7_0_OR_GREATER
    private readonly BreakneckSleep _sleep = new();
#endif
    private readonly Stopwatch _sw = Stopwatch.StartNew();
    /// <summary>
    /// Creates a <see cref="TimeWindow"/>.
    /// </summary>
    /// <param name="sleeping">
    /// Whether <see cref="BeginWindow"/> should sleep until the next window is due to start.
    /// </param>
    // ReSharper disable once UnusedParameter.Local
    public TimeWindow(bool sleeping = true)
    {
#if NET7_0_OR_GREATER
        Sleeping = sleeping;
#endif
    }

    /// <summary>
    /// The duration of a single window. For example, if you wanted to render 60 frames per second, a single frame shall
    /// be thought of as being rendered in a <c>1.0 / 60.0</c> second window.
    /// </summary>
    public TimeSpan Window { get; set; } = TimeSpan.FromSeconds(1.0 / 60.0);

    /// <summary>
    /// The offset from the point at which this <see cref="TimeWindow"/> was constructed (or the last time
    /// <see cref="Reset"/> was called) at which the next window is due to begin.
    /// </summary>
    public TimeSpan NextWindowStart { get; private set; } = TimeSpan.Zero;

    /// <summary>
    /// The offset from the point at which this <see cref="TimeWindow"/> was constructed (or the last time
    /// <see cref="Reset"/> was called) at which the next window is due to begin.
    /// </summary>
    public TimeSpan NextWindowEnd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
        get => NextWindowStart + Window;
    }

    /// <summary>
    /// The offset from the point at which this <see cref="TimeWindow"/> was constructed (or the last time
    /// <see cref="Reset"/> was called).
    /// </summary>
    public TimeSpan CurrentTime
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
        get => _sw.Elapsed;
    }

#if NET7_0_OR_GREATER
    /// <summary>
    /// Whether <see cref="BeginWindow"/> should use <see cref="BreakneckSleep"/>.
    /// </summary>
    private bool Sleeping { get; }
#endif

    /// <summary>
    /// Resets the <see cref="NextWindowStart"/> to zero and the offset from which <see cref="CurrentTime"/> is
    /// measured.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
    public void Reset()
    {
        _sw.Restart();
        NextWindowStart = TimeSpan.Zero;
    }

    /// <summary>
    /// Determines whether the next window is due.
    /// </summary>
    /// <returns>True if the next window is due or overdue, false otherwise.</returns>
    /// <remarks>
    /// If false, do any time-independent, real-time work and call this method again.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
    public bool BeginWindow()
    {
#if NET7_0_OR_GREATER
        var ct = CurrentTime;
        if (Sleeping && ct < NextWindowStart)
        {
            _sleep.Sleep(NextWindowStart - ct);
        }
#endif
        return CurrentTime >= NextWindowStart;
    }

    /// <summary>
    /// Completes this time window.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
    public void EndWindow()
    {
        NextWindowStart += Window;
    }
}
