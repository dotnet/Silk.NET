// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_QUERY_HEAP_DESC.xml' path='doc/member[@name="D3D12_QUERY_HEAP_DESC"]/*'/>
public partial struct D3D12_QUERY_HEAP_DESC
{
    /// <include file='D3D12_QUERY_HEAP_DESC.xml' path='doc/member[@name="D3D12_QUERY_HEAP_DESC.Type"]/*'/>

    public D3D12_QUERY_HEAP_TYPE Type;

    /// <include file='D3D12_QUERY_HEAP_DESC.xml' path='doc/member[@name="D3D12_QUERY_HEAP_DESC.Count"]/*'/>

    public uint Count;

    /// <include file='D3D12_QUERY_HEAP_DESC.xml' path='doc/member[@name="D3D12_QUERY_HEAP_DESC.NodeMask"]/*'/>

    public uint NodeMask;
}
