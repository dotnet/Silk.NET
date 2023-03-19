// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS")]
    public enum VideoEncoderPictureControlFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE")]
        VideoEncoderPictureControlFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"UsedAsReferencePicture\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE")]
        VideoEncoderPictureControlFlagUsedAsReferencePicture = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE")]
        UsedAsReferencePicture = 0x1,
    }
}
