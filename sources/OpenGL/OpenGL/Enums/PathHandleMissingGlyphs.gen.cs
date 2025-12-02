// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathHandleMissingGlyphs")]
public enum PathHandleMissingGlyphs : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SKIP_MISSING_GLYPH_NV")]
    SkipMissingGlyphNV = unchecked((uint)0x90A9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_USE_MISSING_GLYPH_NV")]
    UseMissingGlyphNV = unchecked((uint)0x90AA),
}
