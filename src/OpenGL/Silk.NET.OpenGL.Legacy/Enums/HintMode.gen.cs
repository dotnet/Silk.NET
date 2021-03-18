// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "HintMode")]
    public enum HintMode : int
    {
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_FASTEST")]
        Fastest = 0x1101,
        [NativeName("Name", "GL_NICEST")]
        Nicest = 0x1102,
    }
}
