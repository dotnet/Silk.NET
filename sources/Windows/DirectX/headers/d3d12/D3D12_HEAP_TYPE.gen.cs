// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_HEAP_TYPE.xml' path='doc/member[@name="D3D12_HEAP_TYPE"]/*'/>
public enum D3D12_HEAP_TYPE
{
    /// <include file='D3D12_HEAP_TYPE.xml' path='doc/member[@name="D3D12_HEAP_TYPE.D3D12_HEAP_TYPE_DEFAULT"]/*'/>
    D3D12_HEAP_TYPE_DEFAULT = 1,
    /// <include file='D3D12_HEAP_TYPE.xml' path='doc/member[@name="D3D12_HEAP_TYPE.D3D12_HEAP_TYPE_UPLOAD"]/*'/>
    D3D12_HEAP_TYPE_UPLOAD = 2,
    /// <include file='D3D12_HEAP_TYPE.xml' path='doc/member[@name="D3D12_HEAP_TYPE.D3D12_HEAP_TYPE_READBACK"]/*'/>
    D3D12_HEAP_TYPE_READBACK = 3,
    /// <include file='D3D12_HEAP_TYPE.xml' path='doc/member[@name="D3D12_HEAP_TYPE.D3D12_HEAP_TYPE_CUSTOM"]/*'/>
    D3D12_HEAP_TYPE_CUSTOM = 4,
}