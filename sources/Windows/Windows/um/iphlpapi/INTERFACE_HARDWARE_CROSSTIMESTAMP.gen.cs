// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INTERFACE_HARDWARE_CROSSTIMESTAMP.xml' path='doc/member[@name="INTERFACE_HARDWARE_CROSSTIMESTAMP"]/*' />
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct INTERFACE_HARDWARE_CROSSTIMESTAMP
{
    /// <include file='INTERFACE_HARDWARE_CROSSTIMESTAMP.xml' path='doc/member[@name="INTERFACE_HARDWARE_CROSSTIMESTAMP.SystemTimestamp1"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SystemTimestamp1;

    /// <include file='INTERFACE_HARDWARE_CROSSTIMESTAMP.xml' path='doc/member[@name="INTERFACE_HARDWARE_CROSSTIMESTAMP.HardwareClockTimestamp"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong HardwareClockTimestamp;

    /// <include file='INTERFACE_HARDWARE_CROSSTIMESTAMP.xml' path='doc/member[@name="INTERFACE_HARDWARE_CROSSTIMESTAMP.SystemTimestamp2"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong SystemTimestamp2;
}
