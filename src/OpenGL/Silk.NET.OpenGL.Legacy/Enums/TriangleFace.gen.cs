// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TriangleFace")]
    public enum TriangleFace : int
    {
        [NativeName("Name", "GL_FRONT")]
        Front = 0x404,
        [NativeName("Name", "GL_BACK")]
        Back = 0x405,
        [NativeName("Name", "GL_FRONT_AND_BACK")]
        FrontAndBack = 0x408,
    }
}
