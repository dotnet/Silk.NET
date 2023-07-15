// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_REFLECT_SHARED_PROPERTY.xml' path='doc/member[@name="D3D12_REFLECT_SHARED_PROPERTY"]/*'/>
public enum D3D12_REFLECT_SHARED_PROPERTY
{
    /// <include file='D3D12_REFLECT_SHARED_PROPERTY.xml' path='doc/member[@name="D3D12_REFLECT_SHARED_PROPERTY.D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS"]/*'/>
    D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS = 0,
    /// <include file='D3D12_REFLECT_SHARED_PROPERTY.xml' path='doc/member[@name="D3D12_REFLECT_SHARED_PROPERTY.D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS"]/*'/>
    D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS = (D3D12_REFLECT_SHARED_PROPERTY_D3D11_RESOURCE_FLAGS + 1),
    /// <include file='D3D12_REFLECT_SHARED_PROPERTY.xml' path='doc/member[@name="D3D12_REFLECT_SHARED_PROPERTY.D3D12_REFLECT_SHARED_PROPERTY_NON_NT_SHARED_HANDLE"]/*'/>
    D3D12_REFLECT_SHARED_PROPERTY_NON_NT_SHARED_HANDLE = (D3D12_REFELCT_SHARED_PROPERTY_COMPATIBILITY_SHARED_FLAGS + 1),
}