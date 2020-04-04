// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL
{
    public enum TextureWrapMode
    {
        LinearMipmapLinear = 0x2703,
        Repeat = 0x2901,
        ClampToBorder = 0x812D,
        ClampToBorderArb = 0x812D,
        ClampToBorderNV = 0x812D,
        ClampToBorderSgis = 0x812D,
        ClampToEdge = 0x812F,
        ClampToEdgeSgis = 0x812F,
        MirroredRepeat = 0x8370,
    }
}
