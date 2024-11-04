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
    [NativeName("Name", "PAINT_COLOR_GLYPH")]
    public unsafe partial struct PaintColorGlyph
    {
        public PaintColorGlyph
        (
            uint? glyphIndex = null,
            Silk.NET.Maths.Box2D<float>? clipBox = null
        ) : this()
        {
            if (glyphIndex is not null)
            {
                GlyphIndex = glyphIndex.Value;
            }

            if (clipBox is not null)
            {
                ClipBox = clipBox.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "glyphIndex")]
        public uint GlyphIndex;

        [NativeName("Type", "D2D_RECT_F")]
        [NativeName("Type.Name", "D2D_RECT_F")]
        [NativeName("Name", "clipBox")]
        public Silk.NET.Maths.Box2D<float> ClipBox;
    }
}
