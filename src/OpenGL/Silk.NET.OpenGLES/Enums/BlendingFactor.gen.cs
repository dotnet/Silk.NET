// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "BlendingFactor")]
    public enum BlendingFactor
    {
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_SRC_COLOR")]
        SrcColor = 0x300,
        [NativeName("Name", "GL_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 0x301,
        [NativeName("Name", "GL_SRC_ALPHA")]
        SrcAlpha = 0x302,
        [NativeName("Name", "GL_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 0x303,
        [NativeName("Name", "GL_DST_ALPHA")]
        DstAlpha = 0x304,
        [NativeName("Name", "GL_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 0x305,
        [NativeName("Name", "GL_DST_COLOR")]
        DstColor = 0x306,
        [NativeName("Name", "GL_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 0x307,
        [NativeName("Name", "GL_SRC_ALPHA_SATURATE")]
        SrcAlphaSaturate = 0x308,
        [NativeName("Name", "GL_CONSTANT_COLOR")]
        ConstantColor = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA")]
        ConstantAlpha = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 0x8004,
        [NativeName("Name", "GL_SRC1_ALPHA")]
        Src1Alpha = 0x8589,
        [NativeName("Name", "GL_SRC1_COLOR")]
        Src1Color = 0x88F9,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_COLOR")]
        OneMinusSrc1Color = 0x88FA,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_ALPHA")]
        OneMinusSrc1Alpha = 0x88FB,
    }
}
