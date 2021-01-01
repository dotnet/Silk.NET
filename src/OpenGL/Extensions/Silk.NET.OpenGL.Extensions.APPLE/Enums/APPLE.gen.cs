// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.APPLE
{
    [NativeName("Name", "GLenum")]
    public enum APPLE : int
    {
        [NativeName("Name", "GL_RGB_422_APPLE")]
        Rgb422Apple = 0x8A1F,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_APPLE")]
        UnsignedShort88Apple = 0x85BA,
        [NativeName("Name", "GL_UNSIGNED_SHORT_8_8_REV_APPLE")]
        UnsignedShort88RevApple = 0x85BB,
        [NativeName("Name", "GL_RGB_RAW_422_APPLE")]
        RgbRaw422Apple = 0x8A51,
    }
}
