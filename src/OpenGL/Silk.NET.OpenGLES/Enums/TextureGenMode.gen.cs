// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum TextureGenMode
    {
        EyeLinear = 0x2400,
        ObjectLinear = 0x2401,
        SphereMap = 0x2402,
        EyeDistanceToPointSgis = 0x81F0,
        ObjectDistanceToPointSgis = 0x81F1,
        EyeDistanceToLineSgis = 0x81F2,
        ObjectDistanceToLineSgis = 0x81F3,
    }
}
