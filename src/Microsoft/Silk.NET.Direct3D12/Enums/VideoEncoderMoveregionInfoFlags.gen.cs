// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAGS")]
    public enum VideoEncoderMoveregionInfoFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAG_NONE")]
        VideoEncoderMoveregionInfoFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"MultipleHints\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAG_MULTIPLE_HINTS")]
        VideoEncoderMoveregionInfoFlagMultipleHints = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_MOVEREGION_INFO_FLAG_MULTIPLE_HINTS")]
        MultipleHints = 0x1,
    }
}
