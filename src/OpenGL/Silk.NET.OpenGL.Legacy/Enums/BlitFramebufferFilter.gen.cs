// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "BlitFramebufferFilter")]
    public enum BlitFramebufferFilter : int
    {
        [NativeName("Name", "GL_NEAREST")]
        Nearest = 0x2600,
        [NativeName("Name", "GL_LINEAR")]
        Linear = 0x2601,
    }
}
