// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE"]/*'/>
public enum DXGI_HDR_METADATA_TYPE
{
    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_NONE"]/*'/>
    DXGI_HDR_METADATA_TYPE_NONE = 0,
    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_HDR10"]/*'/>
    DXGI_HDR_METADATA_TYPE_HDR10 = 1,
    /// <include file='DXGI_HDR_METADATA_TYPE.xml' path='doc/member[@name="DXGI_HDR_METADATA_TYPE.DXGI_HDR_METADATA_TYPE_HDR10PLUS"]/*'/>
    DXGI_HDR_METADATA_TYPE_HDR10PLUS = 2,
}