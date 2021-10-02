// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "StencilOp")]
    public enum StencilOp : int
    {
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_INVERT")]
        Invert = 0x150A,
        [NativeName("Name", "GL_KEEP")]
        Keep = 0x1E00,
        [NativeName("Name", "GL_REPLACE")]
        Replace = 0x1E01,
        [NativeName("Name", "GL_INCR")]
        Incr = 0x1E02,
        [NativeName("Name", "GL_DECR")]
        Decr = 0x1E03,
        [NativeName("Name", "GL_INCR_WRAP")]
        IncrWrap = 0x8507,
        [NativeName("Name", "GL_DECR_WRAP")]
        DecrWrap = 0x8508,
    }
}
