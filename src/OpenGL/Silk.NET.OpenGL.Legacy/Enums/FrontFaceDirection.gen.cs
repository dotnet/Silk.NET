// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FrontFaceDirection")]
    public enum FrontFaceDirection : int
    {
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
    }
}
