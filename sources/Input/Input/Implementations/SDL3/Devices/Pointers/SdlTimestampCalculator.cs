// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// The utility class that helps combine SDL timestamps with .NET timestamps to create opportunity for higher time
/// precision where possible.
/// This also helps to intelligently order our timestamps, even if they have the same SDL timestamp.
/// TODO: prove that this is actually useful
/// </summary>
internal static class SdlTimestampCalculator
{
    // sdl's timestamp is in nanoseconds
    private const long _sdlTicksPerSecond = 1_000_000_000;
    private const long _halfSdlTicksPerSecond = _sdlTicksPerSecond / 2;

    private static readonly Int128 _sdlTicksPerSecond128 = _sdlTicksPerSecond;
    private static readonly Int128 _halfSdlTicksPerSecond128 = _halfSdlTicksPerSecond;
    private static readonly Int128 _stopwatchFrequency128 = Stopwatch.Frequency;

    /// <summary>
    /// Represents a "basis" value that can be used to calculate high-precision timestamps using SDL timestamps and
    /// .NET timestamps.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16 * 3)]
    public readonly struct TimeBasis
    {
        [FieldOffset(0)]
        public readonly Int128 SdlRef;
        [FieldOffset(16)]
        public readonly Int128 TimestampRef;

        public TimeBasis(ulong sdlRef, long timestampRef)
        {
            SdlRef = sdlRef;
            TimestampRef = timestampRef;
        }
    }

    public static TimeBasis GetHighPrecisionTimeBasis(int iterationCount)
    {
        // The SDL timestamps deal in nanoseconds, so we take multiple measurements to get the most accurate
        // relationship between SDL and Stopwatch timeestamps

        Span<TimeBasis> calibrations = stackalloc TimeBasis[iterationCount];
        for (byte i = 0; i < iterationCount; i++)
        {
            long nowTimestamp;
            ulong nowSdl;

            // alternate the order in which we do it, so we get a more accurate average that is not influenced
            // as much by the time it takes to acquire each type of measurement
            if (i % 2 == 0)
            {
                nowTimestamp = Stopwatch.GetTimestamp();
                nowSdl = SDL.Sdl.GetTicksNS();
            }
            else
            {
                nowSdl = SDL.Sdl.GetTicksNS();
                nowTimestamp = Stopwatch.GetTimestamp();
            }

            calibrations[i] = new TimeBasis(nowSdl, nowTimestamp);
        }

        return calibrations.Average();
    }

    public static TimeBasis Average(this ReadOnlySpan<TimeBasis> calibrations)
    {
        var sdlRef = Int128.Zero;
        var timestampRef = Int128.Zero;
        for(var i = 0; i < calibrations.Length; i++)
        {
            ref readonly var calibration = ref calibrations[i];
            sdlRef += calibration.SdlRef;
            timestampRef += calibration.TimestampRef;
        }

        var avgSdl = sdlRef / calibrations.Length;
        var avgTimestamp = timestampRef / calibrations.Length;
        return new TimeBasis((ulong)avgSdl, (long)avgTimestamp);
    }

    public static FractionalTimestamp ToTimestamp(ulong sdlTime, in TimeBasis basis)
    {
        var deltaNsSdl = checked(sdlTime - basis.SdlRef);

        // Exact conversion in "ns * stopwatchTicksPerSecond"
        var scaled = deltaNsSdl * _stopwatchFrequency128;

        // Branchless round-to-nearest, ties away from zero.
        var signMask = scaled >> 127; // 0 for non-negative, -1 for negative
        var magnitude = (scaled ^ signMask) - signMask;
        var roundedMagnitude = (magnitude + _halfSdlTicksPerSecond128) / _sdlTicksPerSecond128;
        var roundedDeltaTicks = (roundedMagnitude ^ signMask) - signMask;

        var timestamp = checked((long)(basis.TimestampRef + roundedDeltaTicks));

        // Exact residual after rounding, expressed in "sub-tick units".
        // This is scaled - (rounded tick count * ns-per-second).
        var remainderScaled = scaled - (roundedDeltaTicks * _sdlTicksPerSecond128);
        var remainderAsFractionOfStopwatchTick = (double)remainderScaled / (double)_sdlTicksPerSecond128;

        return new FractionalTimestamp(timestamp, remainderAsFractionOfStopwatchTick);
    }
}

/// <summary>
/// A fractional timestamp, created from the combination of both the SDL timestamp and the .NET timestamp.
/// </summary>
internal readonly struct FractionalTimestamp : IComparable<FractionalTimestamp>
{
    /// <summary>
    /// The converted time from sdl time to stopwatch time.
    /// </summary>
    private readonly long _timestamp;

    /// <summary>
    /// A fraction of a single stopwatch tick (Timestamp value 1) - for scenarios where SDL's time is more accurate
    /// than our stopwatch. This may never happen, but it's worth getting ahead of.
    /// </summary>
    private readonly double _fraction;

    /// <param name="timestamp"><inheritdoc cref="_timestamp"/></param>
    /// <param name="fraction"><inheritdoc cref="_fraction"/></param>
    public FractionalTimestamp(long timestamp, double fraction)
    {
        _timestamp = timestamp;
        _fraction = fraction;
    }

    public int CompareTo(FractionalTimestamp other)
    {
        var timestampComparison = _timestamp.CompareTo(other._timestamp);
        if (timestampComparison is 0)
        {
            timestampComparison = _fraction.CompareTo(other._fraction);
        }

        return timestampComparison;
    }
}
