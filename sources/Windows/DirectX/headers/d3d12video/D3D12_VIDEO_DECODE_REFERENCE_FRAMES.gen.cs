// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_REFERENCE_FRAMES"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_REFERENCE_FRAMES
{
    /// <include file='D3D12_VIDEO_DECODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_REFERENCE_FRAMES.NumTexture2Ds"]/*' />
    public uint NumTexture2Ds;

    /// <include file='D3D12_VIDEO_DECODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_REFERENCE_FRAMES.ppTexture2Ds"]/*' />
    public ID3D12Resource** ppTexture2Ds;

    /// <include file='D3D12_VIDEO_DECODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_REFERENCE_FRAMES.pSubresources"]/*' />
    public uint* pSubresources;

    /// <include file='D3D12_VIDEO_DECODE_REFERENCE_FRAMES.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_REFERENCE_FRAMES.ppHeaps"]/*' />
    public ID3D12VideoDecoderHeap** ppHeaps;
}
