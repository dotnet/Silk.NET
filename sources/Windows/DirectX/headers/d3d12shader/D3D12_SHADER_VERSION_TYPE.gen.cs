// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE"]/*'/>
public enum D3D12_SHADER_VERSION_TYPE
{
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_PIXEL_SHADER"]/*'/>
    D3D12_SHVER_PIXEL_SHADER = 0,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_VERTEX_SHADER"]/*'/>
    D3D12_SHVER_VERTEX_SHADER = 1,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_GEOMETRY_SHADER"]/*'/>
    D3D12_SHVER_GEOMETRY_SHADER = 2,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_HULL_SHADER"]/*'/>
    D3D12_SHVER_HULL_SHADER = 3,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_DOMAIN_SHADER"]/*'/>
    D3D12_SHVER_DOMAIN_SHADER = 4,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_COMPUTE_SHADER"]/*'/>
    D3D12_SHVER_COMPUTE_SHADER = 5,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_LIBRARY"]/*'/>
    D3D12_SHVER_LIBRARY = 6,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_RAY_GENERATION_SHADER"]/*'/>
    D3D12_SHVER_RAY_GENERATION_SHADER = 7,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_INTERSECTION_SHADER"]/*'/>
    D3D12_SHVER_INTERSECTION_SHADER = 8,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_ANY_HIT_SHADER"]/*'/>
    D3D12_SHVER_ANY_HIT_SHADER = 9,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_CLOSEST_HIT_SHADER"]/*'/>
    D3D12_SHVER_CLOSEST_HIT_SHADER = 10,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_MISS_SHADER"]/*'/>
    D3D12_SHVER_MISS_SHADER = 11,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_CALLABLE_SHADER"]/*'/>
    D3D12_SHVER_CALLABLE_SHADER = 12,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_MESH_SHADER"]/*'/>
    D3D12_SHVER_MESH_SHADER = 13,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_AMPLIFICATION_SHADER"]/*'/>
    D3D12_SHVER_AMPLIFICATION_SHADER = 14,
    /// <include file='D3D12_SHADER_VERSION_TYPE.xml' path='doc/member[@name="D3D12_SHADER_VERSION_TYPE.D3D12_SHVER_RESERVED0"]/*'/>
    D3D12_SHVER_RESERVED0 = 0xFFF0,
}