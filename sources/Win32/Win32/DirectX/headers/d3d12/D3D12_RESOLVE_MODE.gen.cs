// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE"]/*'/>
public enum D3D12_RESOLVE_MODE
{
    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_DECOMPRESS"]/*'/>

    D3D12_RESOLVE_MODE_DECOMPRESS = 0,

    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_MIN"]/*'/>

    D3D12_RESOLVE_MODE_MIN = 1,

    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_MAX"]/*'/>

    D3D12_RESOLVE_MODE_MAX = 2,

    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_AVERAGE"]/*'/>

    D3D12_RESOLVE_MODE_AVERAGE = 3,

    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK"]/*'/>

    D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK = 4,

    /// <include file='D3D12_RESOLVE_MODE.xml' path='doc/member[@name="D3D12_RESOLVE_MODE.D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK"]/*'/>

    D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK = 5,
}
