// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelStoreResampleMode")]
    public enum PixelStoreResampleMode
    {
        [NativeName("Name", "GL_RESAMPLE_DECIMATE_SGIX")]
        ResampleDecimateSgix = 0x8430,
        [NativeName("Name", "GL_RESAMPLE_REPLICATE_SGIX")]
        ResampleReplicateSgix = 0x8433,
        [NativeName("Name", "GL_RESAMPLE_ZERO_FILL_SGIX")]
        ResampleZeroFillSgix = 0x8434,
    }
}
