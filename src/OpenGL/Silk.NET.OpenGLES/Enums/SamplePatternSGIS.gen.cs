// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SamplePatternSGIS")]
    public enum SamplePatternSGIS
    {
        [NativeName("Name", "GL_1PASS_EXT")]
        C1PassExt = 0x80A1,
        [NativeName("Name", "GL_1PASS_SGIS")]
        C1PassSgis = 0x80A1,
        [NativeName("Name", "GL_2PASS_0_EXT")]
        C2Pass0Ext = 0x80A2,
        [NativeName("Name", "GL_2PASS_0_SGIS")]
        C2Pass0Sgis = 0x80A2,
        [NativeName("Name", "GL_2PASS_1_EXT")]
        C2Pass1Ext = 0x80A3,
        [NativeName("Name", "GL_2PASS_1_SGIS")]
        C2Pass1Sgis = 0x80A3,
        [NativeName("Name", "GL_4PASS_0_EXT")]
        C4Pass0Ext = 0x80A4,
        [NativeName("Name", "GL_4PASS_0_SGIS")]
        C4Pass0Sgis = 0x80A4,
        [NativeName("Name", "GL_4PASS_1_EXT")]
        C4Pass1Ext = 0x80A5,
        [NativeName("Name", "GL_4PASS_1_SGIS")]
        C4Pass1Sgis = 0x80A5,
        [NativeName("Name", "GL_4PASS_2_EXT")]
        C4Pass2Ext = 0x80A6,
        [NativeName("Name", "GL_4PASS_2_SGIS")]
        C4Pass2Sgis = 0x80A6,
        [NativeName("Name", "GL_4PASS_3_EXT")]
        C4Pass3Ext = 0x80A7,
        [NativeName("Name", "GL_4PASS_3_SGIS")]
        C4Pass3Sgis = 0x80A7,
    }
}
