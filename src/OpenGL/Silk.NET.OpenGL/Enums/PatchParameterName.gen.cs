// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PatchParameterName")]
    public enum PatchParameterName : int
    {
        [NativeName("Name", "GL_PATCH_VERTICES")]
        PatchVertices = 0x8E72,
        [NativeName("Name", "GL_PATCH_DEFAULT_INNER_LEVEL")]
        PatchDefaultInnerLevel = 0x8E73,
        [NativeName("Name", "GL_PATCH_DEFAULT_OUTER_LEVEL")]
        PatchDefaultOuterLevel = 0x8E74,
    }
}
