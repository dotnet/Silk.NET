// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS"]/*'/>
public enum D3D12_VIDEO_DECODE_STATUS
{
    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_OK"]/*'/>

    D3D12_VIDEO_DECODE_STATUS_OK = 0,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_CONTINUE"]/*'/>

    D3D12_VIDEO_DECODE_STATUS_CONTINUE = 1,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY"]/*'/>

    D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY = 2,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_RESTART"]/*'/>

    D3D12_VIDEO_DECODE_STATUS_RESTART = 3,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED"]/*'/>

    D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED = 4,
}
