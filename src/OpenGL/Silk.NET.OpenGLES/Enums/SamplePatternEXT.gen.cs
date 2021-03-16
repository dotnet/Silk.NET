// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SamplePatternEXT")]
    public enum SamplePatternEXT : int
    {
        [NativeName("Name", "GL_1PASS_EXT")]
        Gl1PassExt = 0x80A1,
        [NativeName("Name", "GL_2PASS_0_EXT")]
        Gl2Pass0Ext = 0x80A2,
        [NativeName("Name", "GL_2PASS_1_EXT")]
        Gl2Pass1Ext = 0x80A3,
        [NativeName("Name", "GL_4PASS_0_EXT")]
        Gl4Pass0Ext = 0x80A4,
        [NativeName("Name", "GL_4PASS_1_EXT")]
        Gl4Pass1Ext = 0x80A5,
        [NativeName("Name", "GL_4PASS_2_EXT")]
        Gl4Pass2Ext = 0x80A6,
        [NativeName("Name", "GL_4PASS_3_EXT")]
        Gl4Pass3Ext = 0x80A7,
    }
}
