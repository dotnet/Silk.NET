// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureCompareMode")]
    public enum TextureCompareMode : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COMPARE_R_TO_TEXTURE")]
        CompareRToTexture = 0x884E,
        [NativeName("Name", "GL_COMPARE_REF_TO_TEXTURE")]
        CompareRefToTexture = 0x884E,
    }
}
