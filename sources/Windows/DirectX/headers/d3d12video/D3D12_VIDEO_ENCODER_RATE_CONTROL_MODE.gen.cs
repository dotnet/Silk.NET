// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE"]/*' />
public enum D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP = 0,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP = 1,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR = 2,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR = 3,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR"]/*' />
    D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR = 4,
}
