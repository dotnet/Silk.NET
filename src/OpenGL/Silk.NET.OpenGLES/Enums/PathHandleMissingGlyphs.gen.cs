// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathHandleMissingGlyphs")]
    public enum PathHandleMissingGlyphs : int
    {
        [NativeName("Name", "GL_SKIP_MISSING_GLYPH_NV")]
        SkipMissingGlyphNV = 0x90A9,
        [NativeName("Name", "GL_USE_MISSING_GLYPH_NV")]
        UseMissingGlyphNV = 0x90AA,
    }
}
