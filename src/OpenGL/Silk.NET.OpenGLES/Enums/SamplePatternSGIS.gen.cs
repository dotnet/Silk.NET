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
    public enum SamplePatternSGIS : int
    {
        [NativeName("Name", "GL_1PASS_EXT")]
        Gl1PassExt = 0x80A1,
        [NativeName("Name", "GL_1PASS_SGIS")]
        Gl1PassSgis = 0x80A1,
        [NativeName("Name", "GL_2PASS_0_EXT")]
        Gl2Pass0Ext = 0x80A2,
        [NativeName("Name", "GL_2PASS_0_SGIS")]
        Gl2Pass0Sgis = 0x80A2,
        [NativeName("Name", "GL_2PASS_1_EXT")]
        Gl2Pass1Ext = 0x80A3,
        [NativeName("Name", "GL_2PASS_1_SGIS")]
        Gl2Pass1Sgis = 0x80A3,
        [NativeName("Name", "GL_4PASS_0_EXT")]
        Gl4Pass0Ext = 0x80A4,
        [NativeName("Name", "GL_4PASS_0_SGIS")]
        Gl4Pass0Sgis = 0x80A4,
        [NativeName("Name", "GL_4PASS_1_EXT")]
        Gl4Pass1Ext = 0x80A5,
        [NativeName("Name", "GL_4PASS_1_SGIS")]
        Gl4Pass1Sgis = 0x80A5,
        [NativeName("Name", "GL_4PASS_2_EXT")]
        Gl4Pass2Ext = 0x80A6,
        [NativeName("Name", "GL_4PASS_2_SGIS")]
        Gl4Pass2Sgis = 0x80A6,
        [NativeName("Name", "GL_4PASS_3_EXT")]
        Gl4Pass3Ext = 0x80A7,
        [NativeName("Name", "GL_4PASS_3_SGIS")]
        Gl4Pass3Sgis = 0x80A7,
    }
}
