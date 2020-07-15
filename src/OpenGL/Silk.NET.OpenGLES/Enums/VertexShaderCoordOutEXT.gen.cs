// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexShaderCoordOutEXT")]
    public enum VertexShaderCoordOutEXT
    {
        [NativeName("Name", "GL_X_EXT")]
        XExt = 0x87D5,
        [NativeName("Name", "GL_Y_EXT")]
        YExt = 0x87D6,
        [NativeName("Name", "GL_Z_EXT")]
        ZExt = 0x87D7,
        [NativeName("Name", "GL_W_EXT")]
        WExt = 0x87D8,
        [NativeName("Name", "GL_NEGATIVE_X_EXT")]
        NegativeXExt = 0x87D9,
        [NativeName("Name", "GL_NEGATIVE_Y_EXT")]
        NegativeYExt = 0x87DA,
        [NativeName("Name", "GL_NEGATIVE_Z_EXT")]
        NegativeZExt = 0x87DB,
        [NativeName("Name", "GL_NEGATIVE_W_EXT")]
        NegativeWExt = 0x87DC,
        [NativeName("Name", "GL_ZERO_EXT")]
        ZeroExt = 0x87DD,
        [NativeName("Name", "GL_ONE_EXT")]
        OneExt = 0x87DE,
        [NativeName("Name", "GL_NEGATIVE_ONE_EXT")]
        NegativeOneExt = 0x87DF,
    }
}
