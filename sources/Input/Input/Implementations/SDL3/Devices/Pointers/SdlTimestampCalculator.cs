// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal static class SdlTimestampCalculator
{
    // sdl's timestamp is in nanoseconds
    private const long _sdlTicksPerSecond = 1_000_000_000;
    private const long _halfSdlTicksPerSecond = _sdlTicksPerSecond / 2;

    private static readonly Int128 _sdlTicksPerSecond128 = _sdlTicksPerSecond;
    private static readonly Int128 _halfSdlTicksPerSecond128 = _halfSdlTicksPerSecond;
    private static readonly Int128 _stopwatchFrequency128 = Stopwatch.Frequency;

    [StructLayout(LayoutKind.Explicit, Size = 16 * 3)]
    public readonly struct Basis
    {
        [FieldOffset(0)]
        public readonly Int128 SdlRef;
        [FieldOffset(16)]
        public readonly Int128 TimestampRef;

        public Basis(ulong sdlRef, long timestampRef)
        {
            SdlRef = sdlRef;
            TimestampRef = timestampRef;
        }
    }

    public static Basis Average(this ReadOnlySpan<Basis> calibrations)
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
        return new Basis((ulong)avgSdl, (long)avgTimestamp);
    }

    public static FractionalTimestamp ToTimestamp(ulong sdlTime, in Basis basis)
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

internal readonly struct FractionalTimestamp : IComparable<FractionalTimestamp>
{
    /// <summary>
    /// The converted time from sdl time to stopwatch time.
    /// </summary>
    public readonly long Timestamp;

    /// <summary>
    /// A fraction of a single stopwatch tick (Timestamp value 1) - for scenarios where SDL's time is more accurate
    /// than our stopwatch. This may never happen, but it's worth getting ahead of.
    /// </summary>
    public readonly double Fraction;

    public FractionalTimestamp(long timestamp, double fraction)
    {
        Timestamp = timestamp;
        Fraction = fraction;
    }

    public int CompareTo(FractionalTimestamp other)
    {
        var timestampComparison = Timestamp.CompareTo(other.Timestamp);
        if (timestampComparison != 0)
        {
            return timestampComparison;
        }

        return Fraction.CompareTo(other.Fraction);
    }
}
