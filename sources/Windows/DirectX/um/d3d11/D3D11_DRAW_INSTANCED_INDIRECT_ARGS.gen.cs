// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_DRAW_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INSTANCED_INDIRECT_ARGS"]/*' />
public partial struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS
{
    /// <include file='D3D11_DRAW_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INSTANCED_INDIRECT_ARGS.VertexCountPerInstance"]/*' />
    public uint VertexCountPerInstance;

    /// <include file='D3D11_DRAW_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INSTANCED_INDIRECT_ARGS.InstanceCount"]/*' />
    public uint InstanceCount;

    /// <include file='D3D11_DRAW_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INSTANCED_INDIRECT_ARGS.StartVertexLocation"]/*' />
    public uint StartVertexLocation;

    /// <include file='D3D11_DRAW_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INSTANCED_INDIRECT_ARGS.StartInstanceLocation"]/*' />
    public uint StartInstanceLocation;
}
