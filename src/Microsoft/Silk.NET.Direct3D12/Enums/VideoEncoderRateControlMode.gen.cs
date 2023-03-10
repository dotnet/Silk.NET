// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE")]
    public enum VideoEncoderRateControlMode : int
    {
        [Obsolete("Deprecated in favour of \"AbsoluteQPMap\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP")]
        VideoEncoderRateControlModeAbsoluteQPMap = 0x0,
        [Obsolete("Deprecated in favour of \"Cqp\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP")]
        VideoEncoderRateControlModeCqp = 0x1,
        [Obsolete("Deprecated in favour of \"Cbr\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR")]
        VideoEncoderRateControlModeCbr = 0x2,
        [Obsolete("Deprecated in favour of \"Vbr\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR")]
        VideoEncoderRateControlModeVbr = 0x3,
        [Obsolete("Deprecated in favour of \"Qvbr\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR")]
        VideoEncoderRateControlModeQvbr = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP")]
        AbsoluteQPMap = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP")]
        Cqp = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR")]
        Cbr = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR")]
        Vbr = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR")]
        Qvbr = 0x4,
    }
}
