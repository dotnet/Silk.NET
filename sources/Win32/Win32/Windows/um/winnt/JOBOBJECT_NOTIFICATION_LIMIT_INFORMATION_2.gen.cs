// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2
{
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytesLimit;

    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytesLimit;
    public LARGE_INTEGER PerJobUserTimeLimit;

    [NativeTypeName("__AnonymousRecord_winnt_L13436_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_winnt_L13441_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [NativeTypeName("__AnonymousRecord_winnt_L13446_C5")]
    public _Anonymous3_e__Union Anonymous3;

    [NativeTypeName("DWORD")]
    public uint LimitFlags;
    public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;

    [NativeTypeName("DWORD64")]
    public ulong JobLowMemoryLimit;
    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL IoRateControlToleranceInterval;
    public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;
    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL NetRateControlToleranceInterval;

    [UnscopedRef]
    public ref ulong JobHighMemoryLimit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.JobHighMemoryLimit; }
    }

    [UnscopedRef]
    public ref ulong JobMemoryLimit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.JobMemoryLimit; }
    }

    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.RateControlTolerance; }
    }

    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.CpuRateControlTolerance; }
    }

    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.RateControlToleranceInterval; }
    }

    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous3.CpuRateControlToleranceInterval; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong JobHighMemoryLimit;

        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong JobMemoryLimit;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;

        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval;
    }
}
