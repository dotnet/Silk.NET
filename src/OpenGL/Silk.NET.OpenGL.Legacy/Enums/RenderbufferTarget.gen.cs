// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "RenderbufferTarget")]
    public enum RenderbufferTarget : int
    {
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_RENDERBUFFER_OES")]
        RenderbufferOes = 0x8D41,
    }
}
