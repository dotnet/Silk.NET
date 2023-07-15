// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_SHADER_CACHE_MODE.xml' path='doc/member[@name="D3D12_SHADER_CACHE_MODE"]/*'/>
public enum D3D12_SHADER_CACHE_MODE
{
    /// <include file='D3D12_SHADER_CACHE_MODE.xml' path='doc/member[@name="D3D12_SHADER_CACHE_MODE.D3D12_SHADER_CACHE_MODE_MEMORY"]/*'/>
    D3D12_SHADER_CACHE_MODE_MEMORY = 0,
    /// <include file='D3D12_SHADER_CACHE_MODE.xml' path='doc/member[@name="D3D12_SHADER_CACHE_MODE.D3D12_SHADER_CACHE_MODE_DISK"]/*'/>
    D3D12_SHADER_CACHE_MODE_DISK = (D3D12_SHADER_CACHE_MODE_MEMORY + 1),
}