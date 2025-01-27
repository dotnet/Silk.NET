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
    [NativeName("Name", "PAINT_GLYPH")]
    public unsafe partial struct PaintGlyph
    {
        public PaintGlyph
        (
            uint? glyphIndex = null
        ) : this()
        {
            if (glyphIndex is not null)
            {
                GlyphIndex = glyphIndex.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "glyphIndex")]
        public uint GlyphIndex;
    }
}
