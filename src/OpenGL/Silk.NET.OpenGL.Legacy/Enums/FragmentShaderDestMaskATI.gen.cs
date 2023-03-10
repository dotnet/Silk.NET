// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "FragmentShaderDestMaskATI")]
    public enum FragmentShaderDestMaskATI : int
    {
        [NativeName("Name", "GL_RED_BIT_ATI")]
        RedBitAti = 0x1,
        [NativeName("Name", "GL_GREEN_BIT_ATI")]
        GreenBitAti = 0x2,
        [NativeName("Name", "GL_BLUE_BIT_ATI")]
        BlueBitAti = 0x4,
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
    }
}
