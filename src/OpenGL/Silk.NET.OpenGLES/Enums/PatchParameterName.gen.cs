// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PatchParameterName")]
    public enum PatchParameterName : int
    {
        [Obsolete("Deprecated in favour of \"Vertices\"")]
        [NativeName("Name", "GL_PATCH_VERTICES")]
        PatchVertices = 0x8E72,
        [Obsolete("Deprecated in favour of \"DefaultInnerLevel\"")]
        [NativeName("Name", "GL_PATCH_DEFAULT_INNER_LEVEL")]
        PatchDefaultInnerLevel = 0x8E73,
        [Obsolete("Deprecated in favour of \"DefaultOuterLevel\"")]
        [NativeName("Name", "GL_PATCH_DEFAULT_OUTER_LEVEL")]
        PatchDefaultOuterLevel = 0x8E74,
        [NativeName("Name", "GL_PATCH_VERTICES")]
        Vertices = 0x8E72,
        [NativeName("Name", "GL_PATCH_DEFAULT_INNER_LEVEL")]
        DefaultInnerLevel = 0x8E73,
        [NativeName("Name", "GL_PATCH_DEFAULT_OUTER_LEVEL")]
        DefaultOuterLevel = 0x8E74,
    }
}
