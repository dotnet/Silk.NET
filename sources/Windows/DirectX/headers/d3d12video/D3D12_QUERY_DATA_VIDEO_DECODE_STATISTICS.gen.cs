// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS"]/*'/>
public partial struct D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS
{
    /// <include file='D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.Status"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Status;
    /// <include file='D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.NumMacroblocksAffected"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong NumMacroblocksAffected;
    /// <include file='D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.FrameRate"]/*'/>
    public DXGI_RATIONAL FrameRate;
    /// <include file='D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.xml' path='doc/member[@name="D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS.BitRate"]/*'/>
    public uint BitRate;
}