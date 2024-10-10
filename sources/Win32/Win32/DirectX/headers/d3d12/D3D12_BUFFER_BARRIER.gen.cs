// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER"]/*'/>
public unsafe partial struct D3D12_BUFFER_BARRIER
{
    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.SyncBefore"]/*'/>

    public D3D12_BARRIER_SYNC SyncBefore;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.SyncAfter"]/*'/>

    public D3D12_BARRIER_SYNC SyncAfter;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.AccessBefore"]/*'/>

    public D3D12_BARRIER_ACCESS AccessBefore;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.AccessAfter"]/*'/>

    public D3D12_BARRIER_ACCESS AccessAfter;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.pResource"]/*'/>

    public ID3D12Resource* pResource;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.Offset"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_BUFFER_BARRIER.xml' path='doc/member[@name="D3D12_BUFFER_BARRIER.Size"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Size;
}
