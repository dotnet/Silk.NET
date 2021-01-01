// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
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
