// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum PixelTexGenMode
    {
        None = 0x0,
        Rgb = 0x1907,
        Rgba = 0x1908,
        PixelTexGenAlphaReplaceSgix = 0x8187,
        PixelTexGenAlphaNoReplaceSgix = 0x8188,
        PixelTexGenAlphaLSSgix = 0x8189,
        PixelTexGenAlphaMSSgix = 0x818A,
    }
}
