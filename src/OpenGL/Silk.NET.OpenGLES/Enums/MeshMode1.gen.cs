// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MeshMode1")]
    public enum MeshMode1 : int
    {
        [NativeName("Name", "GL_POINT")]
        Point = 0x1B00,
        [NativeName("Name", "GL_LINE")]
        Line = 0x1B01,
    }
}
