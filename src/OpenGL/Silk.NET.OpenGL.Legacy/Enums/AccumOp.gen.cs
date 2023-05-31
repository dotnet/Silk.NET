// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "AccumOp")]
    public enum AccumOp : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM")]
        Accum = 0x100,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LOAD")]
        Load = 0x101,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_RETURN")]
        Return = 0x102,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MULT")]
        Mult = 0x103,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ADD")]
        Add = 0x104,
    }
}
