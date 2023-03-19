// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE")]
    public enum VideoFieldType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_NONE")]
        VideoFieldTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"InterlacedTopFieldFirst\"")]
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST")]
        VideoFieldTypeInterlacedTopFieldFirst = 0x1,
        [Obsolete("Deprecated in favour of \"InterlacedBottomFieldFirst\"")]
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST")]
        VideoFieldTypeInterlacedBottomFieldFirst = 0x2,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST")]
        InterlacedTopFieldFirst = 0x1,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST")]
        InterlacedBottomFieldFirst = 0x2,
    }
}
