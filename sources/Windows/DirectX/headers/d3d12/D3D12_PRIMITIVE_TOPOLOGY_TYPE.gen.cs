// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE"]/*'/>
public enum D3D12_PRIMITIVE_TOPOLOGY_TYPE
{
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED"]/*'/>
    D3D12_PRIMITIVE_TOPOLOGY_TYPE_UNDEFINED = 0,
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT"]/*'/>
    D3D12_PRIMITIVE_TOPOLOGY_TYPE_POINT = 1,
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE"]/*'/>
    D3D12_PRIMITIVE_TOPOLOGY_TYPE_LINE = 2,
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE"]/*'/>
    D3D12_PRIMITIVE_TOPOLOGY_TYPE_TRIANGLE = 3,
    /// <include file='D3D12_PRIMITIVE_TOPOLOGY_TYPE.xml' path='doc/member[@name="D3D12_PRIMITIVE_TOPOLOGY_TYPE.D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH"]/*'/>
    D3D12_PRIMITIVE_TOPOLOGY_TYPE_PATCH = 4,
}