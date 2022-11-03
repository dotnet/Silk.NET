// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FragmentShaderValueRepATI")]
    public enum FragmentShaderValueRepATI : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_RED")]
        Red = 0x1903,
        [NativeName("Name", "GL_GREEN")]
        Green = 0x1904,
        [NativeName("Name", "GL_BLUE")]
        Blue = 0x1905,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
    }
}
