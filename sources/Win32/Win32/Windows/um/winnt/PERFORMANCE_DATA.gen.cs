// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PERFORMANCE_DATA
{
    [NativeTypeName("WORD")]
    public ushort Size;
    public byte Version;
    public byte HwCountersCount;

    [NativeTypeName("DWORD")]
    public uint ContextSwitchCount;

    [NativeTypeName("DWORD64")]
    public ulong WaitReasonBitMap;

    [NativeTypeName("DWORD64")]
    public ulong CycleTime;

    [NativeTypeName("DWORD")]
    public uint RetryCount;

    [NativeTypeName("DWORD")]
    public uint Reserved;

    [NativeTypeName("HARDWARE_COUNTER_DATA[16]")]
    public _HwCounters_e__FixedBuffer HwCounters;

    [InlineArray(16)]
    public partial struct _HwCounters_e__FixedBuffer
    {
        public HARDWARE_COUNTER_DATA e0;
    }
}
