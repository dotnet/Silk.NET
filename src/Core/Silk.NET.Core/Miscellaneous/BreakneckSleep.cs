// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET7_0_OR_GREATER
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using Silk.NET.Core.Native;

namespace Silk.NET.Core;

/// <summary>
/// Implementation of a high-resolution clock intended for short-duration sleeps.
/// </summary>
public readonly struct BreakneckSleep : IDisposable
{
    /// <summary>
    /// Determines how accurate a <see cref="BreakneckSleep"/> implementation is.
    /// </summary>
    public enum AccuracyMode
    {
        /// <summary>
        /// The underlying implementation can be trusted to be fully accurate.
        /// </summary>
        HighestResolution,
        
        /// <summary>
        /// The underlying implementation is mostly accurate, but uses a busy loop for the 10% to account for potential
        /// inaccuracies. 
        /// </summary>
        HighResolutionWithBusyLoop,
        
        /// <summary>
        /// There is no high-resolution implementation available thus a busy loop is used.
        /// </summary>
        BusyLoopOnly
    }

    /// <summary>
    /// The underlying handle of the timer, if any.
    /// </summary>
    public nint Handle { get; }

    /// <summary>
    /// The duration of the sleep.
    /// </summary>
    public TimeSpan Duration { get; }

    /// <summary>
    /// The accuracy of the underlying implementation. 
    /// </summary>
    public AccuracyMode Accuracy { get; }

    private long _lastTick;

    /// <summary>
    /// Creates a high-resolution timer
    /// </summary>
    /// <param name="duration"></param>
    public BreakneckSleep(TimeSpan duration)
    {
        Duration = duration;
        Accuracy = AccuracyMode.BusyLoopOnly;
        if (OperatingSystem.IsWindows())
        {
            var (handle, isHigh) = WindowsCreate();
            Handle = handle;
            Accuracy = isHigh ? AccuracyMode.HighestResolution : AccuracyMode.HighResolutionWithBusyLoop;
            return;
        }

        Handle = 0;
        if (OperatingSystem.IsLinux() || OperatingSystem.IsMacOS() || OperatingSystem.IsIOS() ||
            OperatingSystem.IsTvOS() || OperatingSystem.IsWatchOS() || OperatingSystem.IsMacCatalyst())
        {
            Accuracy = AccuracyMode.HighResolutionWithBusyLoop;
        }
    }

    public void Start() {
        _lastTick = Stopwatch.GetTimestamp();
    }

    /// <summary>
    /// Sleeps for <see cref="Duration"/>.
    /// </summary>
    public void Sleep()
    {
        var emergencySpin = false;
        if (OperatingSystem.IsWindows())
        {
            emergencySpin = !WindowsWait();
        }

        if (OperatingSystem.IsLinux())
        {
            LinuxWait();
        }

        if (OperatingSystem.IsMacOS() || OperatingSystem.IsIOS() || OperatingSystem.IsTvOS() ||
            OperatingSystem.IsWatchOS() || OperatingSystem.IsMacCatalyst())
        {
            AppleWait();
        }

        if (Accuracy is AccuracyMode.HighResolutionWithBusyLoop or AccuracyMode.BusyLoopOnly || emergencySpin)
        {
            do
            {
                if (X86Base.IsSupported)
                {
                    X86Base.Pause();
                }

                if (ArmBase.IsSupported)
                {
                    ArmBase.Yield();
                }
            } while (Stopwatch.GetElapsedTime(_lastTick, Stopwatch.GetTimestamp()) < Duration);
        }
        _lastTick = Stopwatch.GetTimestamp();
    }

    private static unsafe (nint Handle, bool IsHighResolution) WindowsCreate()
    {
        const uint createWaitableTimerManualReset = 0x00000001;
        const uint createWaitableTimerHighResolution = 0x00000002;
        const uint timerAllAccess = 0x1F0003;
        [DllImport("kernel32.dll", ExactSpelling = true)]
        static extern nint CreateWaitableTimerExW
        (
            SecurityAttributes* lpTimerAttributes,
            char* lpTimerName,
            uint dwFlags,
            uint dwDesiredAccess
        );

        var ret = CreateWaitableTimerExW
            (null, null, createWaitableTimerManualReset | createWaitableTimerHighResolution, timerAllAccess);
        return ret != 0
            ? (ret, true)
            : (CreateWaitableTimerExW(null, null, createWaitableTimerManualReset, timerAllAccess), false);
    }

    private unsafe bool WindowsWait()
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        static extern uint SetWaitableTimerEx
        (
            nint hTimer,
            FILETIME* lpDueTime,
            long lPeriod,
            void* pfnCompletionRoutine,
            void* lpArgToCompletionRoutine,
            void* wakeContext,
            ulong tolerableDelay
        );

        static FILETIME CreateFileTime(TimeSpan ts)
        {
            var ul = unchecked((ulong) -ts.Ticks);
            return new FILETIME
            {
                dwHighDateTime = (int) (ul >> 32),
                dwLowDateTime = (int) (ul & 0xFFFFFFFF)
            };
        }

        var ft = CreateFileTime
        (
            Accuracy == AccuracyMode.HighestResolution
                ? Duration
                : TimeSpan.FromMicroseconds(Duration.TotalMicroseconds * 0.9)
        );
        if (SetWaitableTimerEx(Handle, &ft, 0, null, null, null, 0) == 1)
        {
            SilkMarshal.WaitWindowsObjects(Handle);
            return true;
        }

        return false;
    }

    private unsafe void LinuxWait()
    {
        [DllImport("libc", EntryPoint = "nanosleep")]
        static extern int Nanosleep(Timespec* req, Timespec* rem);

        var ts = new Timespec
        {
            Seconds = Duration.Seconds,
            Nanoseconds = Duration.Nanoseconds - Duration.Seconds * 1000000000
        };
        _ = Nanosleep(&ts, null);
    }

    private void AppleWait()
    {
        [DllImport("libc", EntryPoint = "usleep")]
        static extern int Usleep(uint micros);
        _ = Usleep((uint) (Duration.TotalMicroseconds * 0.9));
    }

    public void Dispose()
    {
        if (OperatingSystem.IsWindows())
        {
            SilkMarshal.ThrowHResult(SilkMarshal.CloseWindowsHandle(Handle));
        }
    }
}
#endif
