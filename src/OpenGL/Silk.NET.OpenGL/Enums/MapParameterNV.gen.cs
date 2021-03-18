// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "MapParameterNV")]
    public enum MapParameterNV : int
    {
        [NativeName("Name", "GL_MAP_TESSELLATION_NV")]
        MapTessellationNV = 0x86C2,
    }
}
