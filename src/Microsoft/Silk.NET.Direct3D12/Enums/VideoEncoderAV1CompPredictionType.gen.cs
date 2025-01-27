// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE")]
    public enum VideoEncoderAV1CompPredictionType : int
    {
        [Obsolete("Deprecated in favour of \"SingleReference\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_SINGLE_REFERENCE")]
        VideoEncoderAV1CompPredictionTypeSingleReference = 0x0,
        [Obsolete("Deprecated in favour of \"CompoundReference\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_COMPOUND_REFERENCE")]
        VideoEncoderAV1CompPredictionTypeCompoundReference = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_SINGLE_REFERENCE")]
        SingleReference = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_COMPOUND_REFERENCE")]
        CompoundReference = 0x1,
    }
}
