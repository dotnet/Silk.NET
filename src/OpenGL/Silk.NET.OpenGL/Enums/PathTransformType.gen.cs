// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum PathTransformType
    {
        None = 0x0,
        TranslateXNV = 0x908E,
        TranslateYNV = 0x908F,
        Translate2DNV = 0x9090,
        Translate3DNV = 0x9091,
        Affine2DNV = 0x9092,
        Affine3DNV = 0x9094,
        TransposeAffine2DNV = 0x9096,
        TransposeAffine3DNV = 0x9098,
    }
}
