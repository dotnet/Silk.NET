// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE")]
    public enum VideoEncoderRateControlMode : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP")]
        VideoEncoderRateControlModeAbsoluteQPMap = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP")]
        VideoEncoderRateControlModeCqp = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR")]
        VideoEncoderRateControlModeCbr = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR")]
        VideoEncoderRateControlModeVbr = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR")]
        VideoEncoderRateControlModeQvbr = 0x4,
    }
}
