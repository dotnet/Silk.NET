// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY"]/*'/>
public enum D3D12_SHADER_VISIBILITY
{
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_ALL"]/*'/>
    D3D12_SHADER_VISIBILITY_ALL = 0,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_VERTEX"]/*'/>
    D3D12_SHADER_VISIBILITY_VERTEX = 1,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_HULL"]/*'/>
    D3D12_SHADER_VISIBILITY_HULL = 2,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_DOMAIN"]/*'/>
    D3D12_SHADER_VISIBILITY_DOMAIN = 3,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_GEOMETRY"]/*'/>
    D3D12_SHADER_VISIBILITY_GEOMETRY = 4,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_PIXEL"]/*'/>
    D3D12_SHADER_VISIBILITY_PIXEL = 5,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_AMPLIFICATION"]/*'/>
    D3D12_SHADER_VISIBILITY_AMPLIFICATION = 6,
    /// <include file='D3D12_SHADER_VISIBILITY.xml' path='doc/member[@name="D3D12_SHADER_VISIBILITY.D3D12_SHADER_VISIBILITY_MESH"]/*'/>
    D3D12_SHADER_VISIBILITY_MESH = 7,
}