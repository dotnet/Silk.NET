// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES"]/*' />
public partial struct MFCLOCK_PROPERTIES
{
    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.qwCorrelationRate"]/*' />
    [NativeTypeName("unsigned long long")]
    public ulong qwCorrelationRate;

    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.guidClockId"]/*' />
    public Guid guidClockId;

    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.dwClockFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwClockFlags;

    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.qwClockFrequency"]/*' />
    [NativeTypeName("unsigned long long")]
    public ulong qwClockFrequency;

    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.dwClockTolerance"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwClockTolerance;

    /// <include file='MFCLOCK_PROPERTIES.xml' path='doc/member[@name="MFCLOCK_PROPERTIES.dwClockJitter"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwClockJitter;
}
