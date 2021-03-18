// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "StencilFunction")]
    public enum StencilFunction : int
    {
        [NativeName("Name", "GL_NEVER")]
        Never = 0x200,
        [NativeName("Name", "GL_LESS")]
        Less = 0x201,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_LEQUAL")]
        Lequal = 0x203,
        [NativeName("Name", "GL_GREATER")]
        Greater = 0x204,
        [NativeName("Name", "GL_NOTEQUAL")]
        Notequal = 0x205,
        [NativeName("Name", "GL_GEQUAL")]
        Gequal = 0x206,
        [NativeName("Name", "GL_ALWAYS")]
        Always = 0x207,
    }
}
