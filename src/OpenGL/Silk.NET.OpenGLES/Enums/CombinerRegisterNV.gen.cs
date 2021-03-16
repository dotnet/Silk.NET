// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "CombinerRegisterNV")]
    public enum CombinerRegisterNV : int
    {
        [NativeName("Name", "GL_TEXTURE0_ARB")]
        Texture0Arb = 0x84C0,
        [NativeName("Name", "GL_TEXTURE1_ARB")]
        Texture1Arb = 0x84C1,
        [NativeName("Name", "GL_PRIMARY_COLOR_NV")]
        PrimaryColorNV = 0x852C,
        [NativeName("Name", "GL_SECONDARY_COLOR_NV")]
        SecondaryColorNV = 0x852D,
        [NativeName("Name", "GL_SPARE0_NV")]
        Spare0NV = 0x852E,
        [NativeName("Name", "GL_SPARE1_NV")]
        Spare1NV = 0x852F,
        [NativeName("Name", "GL_DISCARD_NV")]
        DiscardNV = 0x8530,
    }
}
