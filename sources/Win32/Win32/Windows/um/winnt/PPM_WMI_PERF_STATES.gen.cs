// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PPM_WMI_PERF_STATES
{
    [NativeTypeName("DWORD")]
    public uint Count;

    [NativeTypeName("DWORD")]
    public uint MaxFrequency;

    [NativeTypeName("DWORD")]
    public uint CurrentState;

    [NativeTypeName("DWORD")]
    public uint MaxPerfState;

    [NativeTypeName("DWORD")]
    public uint MinPerfState;

    [NativeTypeName("DWORD")]
    public uint LowestPerfState;

    [NativeTypeName("DWORD")]
    public uint ThermalConstraint;
    public byte BusyAdjThreshold;
    public byte PolicyType;
    public byte Type;
    public byte Reserved;

    [NativeTypeName("DWORD")]
    public uint TimerInterval;

    [NativeTypeName("DWORD64")]
    public ulong TargetProcessors;

    [NativeTypeName("DWORD")]
    public uint PStateHandler;

    [NativeTypeName("DWORD")]
    public uint PStateContext;

    [NativeTypeName("DWORD")]
    public uint TStateHandler;

    [NativeTypeName("DWORD")]
    public uint TStateContext;

    [NativeTypeName("DWORD")]
    public uint FeedbackHandler;

    [NativeTypeName("DWORD")]
    public uint Reserved1;

    [NativeTypeName("DWORD64")]
    public ulong Reserved2;

    [NativeTypeName("PPM_WMI_PERF_STATE[1]")]
    public _State_e__FixedBuffer State;

    public partial struct _State_e__FixedBuffer
    {
        public PPM_WMI_PERF_STATE e0;

        [UnscopedRef]
        public ref PPM_WMI_PERF_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_WMI_PERF_STATE> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
