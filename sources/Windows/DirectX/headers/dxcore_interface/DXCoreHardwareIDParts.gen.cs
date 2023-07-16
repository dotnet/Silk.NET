// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts"]/*'/>
public partial struct DXCoreHardwareIDParts
{
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.vendorID"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint vendorID;
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.deviceID"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint deviceID;
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subSystemID"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint subSystemID;
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subVendorID"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint subVendorID;
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.revisionID"]/*'/>
    [NativeTypeName("uint32_t")]
    public uint revisionID;
}