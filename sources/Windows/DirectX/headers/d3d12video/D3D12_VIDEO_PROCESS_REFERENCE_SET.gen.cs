// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET"]/*'/>
public unsafe partial struct D3D12_VIDEO_PROCESS_REFERENCE_SET
{
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.NumPastFrames"]/*'/>
    public uint NumPastFrames;
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.ppPastFrames"]/*'/>
    public ID3D12Resource** ppPastFrames;
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.pPastSubresources"]/*'/>
    public uint* pPastSubresources;
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.NumFutureFrames"]/*'/>
    public uint NumFutureFrames;
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.ppFutureFrames"]/*'/>
    public ID3D12Resource** ppFutureFrames;
    /// <include file='D3D12_VIDEO_PROCESS_REFERENCE_SET.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_REFERENCE_SET.pFutureSubresources"]/*'/>
    public uint* pFutureSubresources;
}