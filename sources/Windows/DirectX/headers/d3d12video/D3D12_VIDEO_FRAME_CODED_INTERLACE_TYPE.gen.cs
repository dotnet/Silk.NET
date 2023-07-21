// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE"]/*' />
public enum D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE
{
    /// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE"]/*' />
    D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE = 0,

    /// <include file='D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE.D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED"]/*' />
    D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED = 1,
}
