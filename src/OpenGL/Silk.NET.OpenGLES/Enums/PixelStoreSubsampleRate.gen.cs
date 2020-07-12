// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelStoreSubsampleRate")]
    public enum PixelStoreSubsampleRate
    {
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4444_SGIX")]
        PixelSubsample4444Sgix = 0x85A2,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_2424_SGIX")]
        PixelSubsample2424Sgix = 0x85A3,
        [NativeName("Name", "GL_PIXEL_SUBSAMPLE_4242_SGIX")]
        PixelSubsample4242Sgix = 0x85A4,
    }
}
