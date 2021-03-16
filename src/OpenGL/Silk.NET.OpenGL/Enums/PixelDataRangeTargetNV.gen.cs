// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelDataRangeTargetNV")]
    public enum PixelDataRangeTargetNV : int
    {
        [NativeName("Name", "GL_WRITE_PIXEL_DATA_RANGE_NV")]
        WritePixelDataRangeNV = 0x8878,
        [NativeName("Name", "GL_READ_PIXEL_DATA_RANGE_NV")]
        ReadPixelDataRangeNV = 0x8879,
    }
}
