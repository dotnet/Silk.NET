// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureGenParameter")]
    public enum TextureGenParameter : int
    {
        [NativeName("Name", "GL_EYE_POINT_SGIS")]
        EyePointSgis = 0x81F4,
        [NativeName("Name", "GL_OBJECT_POINT_SGIS")]
        ObjectPointSgis = 0x81F5,
        [NativeName("Name", "GL_EYE_LINE_SGIS")]
        EyeLineSgis = 0x81F6,
        [NativeName("Name", "GL_OBJECT_LINE_SGIS")]
        ObjectLineSgis = 0x81F7,
    }
}
