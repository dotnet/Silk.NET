// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB"]/*'/>
public partial struct D3D12_RAYTRACING_AABB
{
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MinX"]/*'/>
    public float MinX;
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MinY"]/*'/>
    public float MinY;
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MinZ"]/*'/>
    public float MinZ;
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MaxX"]/*'/>
    public float MaxX;
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MaxY"]/*'/>
    public float MaxY;
    /// <include file='D3D12_RAYTRACING_AABB.xml' path='doc/member[@name="D3D12_RAYTRACING_AABB.MaxZ"]/*'/>
    public float MaxZ;
}