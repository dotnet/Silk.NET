// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "Boolean")]
    public enum Boolean : int
    {
        [NativeName("Name", "GL_FALSE")]
        False = 0x0,
        [NativeName("Name", "GL_TRUE")]
        True = 0x1,
    }
}
