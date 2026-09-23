// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

/// <summary>
/// The utility class that helps combine SDL timestamps with .NET timestamps to create opportunity for higher time
/// precision where possible.
/// This also helps to intelligently order our timestamps, even if they have the same SDL timestamp.
/// TODO: prove that this is actually useful beyond a shadow of a doubt
/// </summary>
internal static class SdlTimestampCalculator
{
    // sdl's timestamp is in nanoseconds
    private const long _sdlTicksPerSecond = 1_000_000_000;
    private const double _inverseSdlTicksPerSecond = 1d / _sdlTicksPerSecond;

    private static readonly Int128 _sdlTicksPerSecond128 = _sdlTicksPerSecond;
    private static readonly Int128 _stopwatchFrequency128 = Stopwatch.Frequency;

    /// <summary>
    /// Represents a "basis" value that can be used to calculate high-precision timestamps using SDL timestamps and
    /// .NET timestamps.
    /// </summary>
    public readonly struct TimeBasis
    {
        public readonly ulong SdlRef;
        public readonly long TimestampRef;

        public TimeBasis(ulong sdlRef, long timestampRef)
        {
            SdlRef = sdlRef;
            TimestampRef = timestampRef;
        }
    }

    [SkipLocalsInit]
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

        return Average(ref calibrations);

        static TimeBasis Average(ref readonly Span<TimeBasis> calibrations)
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
    }

    public static long ToTimestamp(ulong sdlTime, in TimeBasis basis)
    {
        var deltaNs = unchecked((long)(sdlTime - basis.SdlRef));
        var (wholeTicks, remainder) = Int128.DivRem(
            left: deltaNs * _stopwatchFrequency128,
            right: _sdlTicksPerSecond128);

        var timestampTruncated = basis.TimestampRef + (long)wholeTicks;
        var fraction = (long)remainder * _inverseSdlTicksPerSecond;
        return fraction >= 0.5 ? timestampTruncated + 1 : timestampTruncated;
    }
}
