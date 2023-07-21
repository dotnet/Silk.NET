// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='INTERFACE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_TIMESTAMP_CAPABILITIES"]/*' />
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct INTERFACE_TIMESTAMP_CAPABILITIES
{
    /// <include file='INTERFACE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_TIMESTAMP_CAPABILITIES.HardwareClockFrequencyHz"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong HardwareClockFrequencyHz;

    /// <include file='INTERFACE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_TIMESTAMP_CAPABILITIES.SupportsCrossTimestamp"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte SupportsCrossTimestamp;

    /// <include file='INTERFACE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_TIMESTAMP_CAPABILITIES.HardwareCapabilities"]/*' />
    public INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES HardwareCapabilities;

    /// <include file='INTERFACE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_TIMESTAMP_CAPABILITIES.SoftwareCapabilities"]/*' />
    public INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES SoftwareCapabilities;
}
