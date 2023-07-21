// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreHardwareID
{
    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.vendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vendorID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.deviceID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint deviceID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.subSysID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint subSysID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.revision"]/*' />
    [NativeTypeName("uint32_t")]
    public uint revision;
}
