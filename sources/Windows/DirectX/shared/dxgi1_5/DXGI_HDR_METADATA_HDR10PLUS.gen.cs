// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DXGI_HDR_METADATA_HDR10PLUS.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS"]/*' />
public unsafe partial struct DXGI_HDR_METADATA_HDR10PLUS
{
    /// <include file='DXGI_HDR_METADATA_HDR10PLUS.xml' path='doc/member[@name="DXGI_HDR_METADATA_HDR10PLUS.Data"]/*' />
    [NativeTypeName("BYTE[72]")]
    public fixed byte Data[72];
}
