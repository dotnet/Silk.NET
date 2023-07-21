// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_BUFFER_UAV.xml' path='doc/member[@name="D3D11_BUFFER_UAV"]/*' />
public partial struct D3D11_BUFFER_UAV
{
    /// <include file='D3D11_BUFFER_UAV.xml' path='doc/member[@name="D3D11_BUFFER_UAV.FirstElement"]/*' />
    public uint FirstElement;

    /// <include file='D3D11_BUFFER_UAV.xml' path='doc/member[@name="D3D11_BUFFER_UAV.NumElements"]/*' />
    public uint NumElements;

    /// <include file='D3D11_BUFFER_UAV.xml' path='doc/member[@name="D3D11_BUFFER_UAV.Flags"]/*' />
    public uint Flags;
}
