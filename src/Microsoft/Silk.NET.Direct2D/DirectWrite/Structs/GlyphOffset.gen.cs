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
    [NativeName("Name", "DWRITE_GLYPH_OFFSET")]
    public unsafe partial struct GlyphOffset
    {
        public GlyphOffset
        (
            float? advanceOffset = null,
            float? ascenderOffset = null
        ) : this()
        {
            if (advanceOffset is not null)
            {
                AdvanceOffset = advanceOffset.Value;
            }

            if (ascenderOffset is not null)
            {
                AscenderOffset = ascenderOffset.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "advanceOffset")]
        public float AdvanceOffset;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ascenderOffset")]
        public float AscenderOffset;
    }
}
