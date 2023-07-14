// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PathGenMode")]
    public enum PathGenMode : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EYE_LINEAR")]
        EyeLinear = 0x2400,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_OBJECT_LINEAR")]
        ObjectLinear = 0x2401,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CONSTANT")]
        Constant = 0x8576,
        [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
        PathObjectBoundingBoxNV = 0x908A,
    }
}
