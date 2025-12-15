// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE")]
    public enum VideoFrameCodedInterlaceType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE")]
        VideoFrameCodedInterlaceTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"FieldBased\"")]
        [NativeName("Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED")]
        VideoFrameCodedInterlaceTypeFieldBased = 0x1,
        [NativeName("Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE_FIELD_BASED")]
        FieldBased = 0x1,
    }
}
