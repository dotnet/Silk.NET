// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX"]/*' />
public unsafe partial struct PPM_WMI_PERF_STATES_EX
{
    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.MaxFrequency"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxFrequency;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.CurrentState"]/*' />
    [NativeTypeName("DWORD")]
    public uint CurrentState;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.MaxPerfState"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxPerfState;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.MinPerfState"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinPerfState;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.LowestPerfState"]/*' />
    [NativeTypeName("DWORD")]
    public uint LowestPerfState;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.ThermalConstraint"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThermalConstraint;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.BusyAdjThreshold"]/*' />
    public byte BusyAdjThreshold;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.PolicyType"]/*' />
    public byte PolicyType;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.Type"]/*' />
    public byte Type;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.Reserved"]/*' />
    public byte Reserved;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.TimerInterval"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimerInterval;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.TargetProcessors"]/*' />
    [NativeTypeName("PVOID")]
    public void* TargetProcessors;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.PStateHandler"]/*' />
    [NativeTypeName("DWORD")]
    public uint PStateHandler;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.PStateContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint PStateContext;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.TStateHandler"]/*' />
    [NativeTypeName("DWORD")]
    public uint TStateHandler;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.TStateContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint TStateContext;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.FeedbackHandler"]/*' />
    [NativeTypeName("DWORD")]
    public uint FeedbackHandler;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.Reserved2"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Reserved2;

    /// <include file='PPM_WMI_PERF_STATES_EX.xml' path='doc/member[@name="PPM_WMI_PERF_STATES_EX.State"]/*' />
    [NativeTypeName("PPM_WMI_PERF_STATE[1]")]
    public _State_e__FixedBuffer State;

    /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*' />
    public partial struct _State_e__FixedBuffer
    {
        public PPM_WMI_PERF_STATE e0;

        [UnscopedRef]
        public ref PPM_WMI_PERF_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_WMI_PERF_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
