// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFCLOCK_PROPERTIES
{
    [NativeTypeName("unsigned long long")]
    public ulong qwCorrelationRate;
    public Guid guidClockId;

    [NativeTypeName("DWORD")]
    public uint dwClockFlags;

    [NativeTypeName("unsigned long long")]
    public ulong qwClockFrequency;

    [NativeTypeName("DWORD")]
    public uint dwClockTolerance;

    [NativeTypeName("DWORD")]
    public uint dwClockJitter;
}
