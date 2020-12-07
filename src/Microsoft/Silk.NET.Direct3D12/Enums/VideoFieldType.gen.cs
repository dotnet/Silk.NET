// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE")]
    public enum VideoFieldType
    {
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_NONE")]
        VideoFieldTypeNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_TOP_FIELD_FIRST")]
        VideoFieldTypeInterlacedTopFieldFirst = 0x1,
        [NativeName("Name", "D3D12_VIDEO_FIELD_TYPE_INTERLACED_BOTTOM_FIELD_FIRST")]
        VideoFieldTypeInterlacedBottomFieldFirst = 0x2,
    }
}
