// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES
{
    /// <include file='INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.AllReceive"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AllReceive;
    /// <include file='INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.AllTransmit"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AllTransmit;
    /// <include file='INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.xml' path='doc/member[@name="INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES.TaggedTransmit"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte TaggedTransmit;
}