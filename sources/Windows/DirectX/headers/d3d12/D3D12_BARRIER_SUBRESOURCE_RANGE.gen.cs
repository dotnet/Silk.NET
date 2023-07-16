// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE"]/*'/>
public partial struct D3D12_BARRIER_SUBRESOURCE_RANGE
{
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.IndexOrFirstMipLevel"]/*'/>
    public uint IndexOrFirstMipLevel;
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.NumMipLevels"]/*'/>
    public uint NumMipLevels;
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.FirstArraySlice"]/*'/>
    public uint FirstArraySlice;
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.NumArraySlices"]/*'/>
    public uint NumArraySlices;
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.FirstPlane"]/*'/>
    public uint FirstPlane;
    /// <include file='D3D12_BARRIER_SUBRESOURCE_RANGE.xml' path='doc/member[@name="D3D12_BARRIER_SUBRESOURCE_RANGE.NumPlanes"]/*'/>
    public uint NumPlanes;
}