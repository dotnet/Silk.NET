// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC"]/*'/>
public partial struct D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.Transform3x4"]/*'/>

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong Transform3x4;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.IndexFormat"]/*'/>

    public DXGI_FORMAT IndexFormat;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.VertexFormat"]/*'/>

    public DXGI_FORMAT VertexFormat;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.IndexCount"]/*'/>

    public uint IndexCount;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.VertexCount"]/*'/>

    public uint VertexCount;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.IndexBuffer"]/*'/>

    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong IndexBuffer;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC.VertexBuffer"]/*'/>

    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE VertexBuffer;
}
