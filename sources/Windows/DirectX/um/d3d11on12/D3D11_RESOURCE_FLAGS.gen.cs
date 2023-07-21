// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D11_RESOURCE_FLAGS"]/*' />
public partial struct D3D11_RESOURCE_FLAGS
{
    /// <include file='D3D11_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D11_RESOURCE_FLAGS.BindFlags"]/*' />
    public uint BindFlags;

    /// <include file='D3D11_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D11_RESOURCE_FLAGS.MiscFlags"]/*' />
    public uint MiscFlags;

    /// <include file='D3D11_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D11_RESOURCE_FLAGS.CPUAccessFlags"]/*' />
    public uint CPUAccessFlags;

    /// <include file='D3D11_RESOURCE_FLAGS.xml' path='doc/member[@name="D3D11_RESOURCE_FLAGS.StructureByteStride"]/*' />
    public uint StructureByteStride;
}
