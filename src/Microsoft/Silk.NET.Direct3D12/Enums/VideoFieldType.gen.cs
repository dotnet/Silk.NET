// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE")]
    public enum VideoFieldType : int
    {
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_NONE")]
        VideoFieldTypeNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST")]
        VideoFieldTypeInterlacedTopFieldFirst = 0x1,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST")]
        VideoFieldTypeInterlacedBottomFieldFirst = 0x2,
    }
}
