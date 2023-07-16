// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS"]/*'/>
public partial struct D3D12_DRAW_INDEXED_ARGUMENTS
{
    /// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS.IndexCountPerInstance"]/*'/>
    public uint IndexCountPerInstance;
    /// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS.InstanceCount"]/*'/>
    public uint InstanceCount;
    /// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS.StartIndexLocation"]/*'/>
    public uint StartIndexLocation;
    /// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS.BaseVertexLocation"]/*'/>
    public int BaseVertexLocation;
    /// <include file='D3D12_DRAW_INDEXED_ARGUMENTS.xml' path='doc/member[@name="D3D12_DRAW_INDEXED_ARGUMENTS.StartInstanceLocation"]/*'/>
    public uint StartInstanceLocation;
}