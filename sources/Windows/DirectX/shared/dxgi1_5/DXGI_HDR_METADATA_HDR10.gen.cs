// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10"]/*'/>
public unsafe partial struct DXGI_HDR_METADATA_HDR10
{
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.RedPrimary"]/*'/>
    [NativeTypeName("UINT16[2]")]
    public fixed ushort RedPrimary[2];
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.GreenPrimary"]/*'/>
    [NativeTypeName("UINT16[2]")]
    public fixed ushort GreenPrimary[2];
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.BluePrimary"]/*'/>
    [NativeTypeName("UINT16[2]")]
    public fixed ushort BluePrimary[2];
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.WhitePoint"]/*'/>
    [NativeTypeName("UINT16[2]")]
    public fixed ushort WhitePoint[2];
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxMasteringLuminance"]/*'/>
    public uint MaxMasteringLuminance;
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MinMasteringLuminance"]/*'/>
    public uint MinMasteringLuminance;
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxContentLightLevel"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MaxContentLightLevel;
    /// <include file='DXGI_HDR_METADATA_HDR10.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10.MaxFrameAverageLightLevel"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MaxFrameAverageLightLevel;
}