// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelTransformTargetEXT")]
    public enum PixelTransformTargetEXT : int
    {
        [NativeName("Name", "GL_PIXEL_TRANSFORM_2D_EXT")]
        PixelTransform2DExt = 0x8330,
    }
}
