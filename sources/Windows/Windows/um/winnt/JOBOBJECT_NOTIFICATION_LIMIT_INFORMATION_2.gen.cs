// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2
{
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.IoReadBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytesLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.IoWriteBytesLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytesLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.PerJobUserTimeLimit"]/*'/>
    public LARGE_INTEGER PerJobUserTimeLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L12948_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L12953_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.Anonymous3"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L12958_C5")]
    public _Anonymous3_e__Union Anonymous3;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.LimitFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LimitFlags;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.IoRateControlTolerance"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE IoRateControlTolerance;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.JobLowMemoryLimit"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong JobLowMemoryLimit;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.IoRateControlToleranceInterval"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL IoRateControlToleranceInterval;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.NetRateControlTolerance"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE NetRateControlTolerance;
    /// <include file='JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.xml' path='doc/member[@name="JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION_2.NetRateControlToleranceInterval"]/*'/>
    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL NetRateControlToleranceInterval;
    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobHighMemoryLimit"]/*'/>
    [UnscopedRef]
    public ref ulong JobHighMemoryLimit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.JobHighMemoryLimit;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobMemoryLimit"]/*'/>
    [UnscopedRef]
    public ref ulong JobMemoryLimit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.JobMemoryLimit;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.RateControlTolerance"]/*'/>
    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.RateControlTolerance;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.CpuRateControlTolerance"]/*'/>
    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.CpuRateControlTolerance;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.RateControlToleranceInterval"]/*'/>
    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.RateControlToleranceInterval;
        }
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.CpuRateControlToleranceInterval"]/*'/>
    [UnscopedRef]
    public ref JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous3.CpuRateControlToleranceInterval;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobHighMemoryLimit"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong JobHighMemoryLimit;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.JobMemoryLimit"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong JobMemoryLimit;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.RateControlTolerance"]/*'/>
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.CpuRateControlTolerance"]/*'/>
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE CpuRateControlTolerance;
    }

    /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous3_e__Union
    {
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.RateControlToleranceInterval"]/*'/>
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;
        /// <include file='_Anonymous3_e__Union.xml' path='doc/member[@name="_Anonymous3_e__Union.CpuRateControlToleranceInterval"]/*'/>
        [FieldOffset(0)]
        public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL CpuRateControlToleranceInterval;
    }
}