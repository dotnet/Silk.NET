// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS"]/*'/>
public enum D3D12_SHADER_CACHE_CONTROL_FLAGS
{
    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE"]/*'/>
    D3D12_SHADER_CACHE_CONTROL_FLAG_DISABLE = 0x1,
    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE"]/*'/>
    D3D12_SHADER_CACHE_CONTROL_FLAG_ENABLE = 0x2,
    /// <include file='D3D12_SHADER_CACHE_CONTROL_FLAGS.xml' path='doc/member[@name="D3D12_SHADER_CACHE_CONTROL_FLAGS.D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR"]/*'/>
    D3D12_SHADER_CACHE_CONTROL_FLAG_CLEAR = 0x4,
}