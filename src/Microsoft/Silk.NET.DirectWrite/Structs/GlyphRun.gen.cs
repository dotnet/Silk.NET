// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_GLYPH_RUN")]
    public unsafe partial struct GlyphRun
    {
        public GlyphRun
        (
            IDWriteFontFace* fontFace = null,
            float? fontEmSize = null,
            uint? glyphCount = null,
            ushort* glyphIndices = null,
            float* glyphAdvances = null,
            GlyphOffset* glyphOffsets = null,
            Silk.NET.Core.Bool32? isSideways = null,
            uint? bidiLevel = null
        ) : this()
        {
            if (fontFace is not null)
            {
                FontFace = fontFace;
            }

            if (fontEmSize is not null)
            {
                FontEmSize = fontEmSize.Value;
            }

            if (glyphCount is not null)
            {
                GlyphCount = glyphCount.Value;
            }

            if (glyphIndices is not null)
            {
                GlyphIndices = glyphIndices;
            }

            if (glyphAdvances is not null)
            {
                GlyphAdvances = glyphAdvances;
            }

            if (glyphOffsets is not null)
            {
                GlyphOffsets = glyphOffsets;
            }

            if (isSideways is not null)
            {
                IsSideways = isSideways.Value;
            }

            if (bidiLevel is not null)
            {
                BidiLevel = bidiLevel.Value;
            }
        }


        [NativeName("Type", "IDWriteFontFace *")]
        [NativeName("Type.Name", "IDWriteFontFace *")]
        [NativeName("Name", "fontFace")]
        public IDWriteFontFace* FontFace;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "fontEmSize")]
        public float FontEmSize;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "glyphCount")]
        public uint GlyphCount;

        [NativeName("Type", "const UINT16 *")]
        [NativeName("Type.Name", "const UINT16 *")]
        [NativeName("Name", "glyphIndices")]
        public ushort* GlyphIndices;

        [NativeName("Type", "const FLOAT *")]
        [NativeName("Type.Name", "const FLOAT *")]
        [NativeName("Name", "glyphAdvances")]
        public float* GlyphAdvances;

        [NativeName("Type", "const DWRITE_GLYPH_OFFSET *")]
        [NativeName("Type.Name", "const DWRITE_GLYPH_OFFSET *")]
        [NativeName("Name", "glyphOffsets")]
        public GlyphOffset* GlyphOffsets;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "isSideways")]
        public Silk.NET.Core.Bool32 IsSideways;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "bidiLevel")]
        public uint BidiLevel;
    }
}
