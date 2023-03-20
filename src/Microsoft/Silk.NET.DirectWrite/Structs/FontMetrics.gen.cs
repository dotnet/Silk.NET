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
    [NativeName("Name", "DWRITE_FONT_METRICS")]
    public unsafe partial struct FontMetrics
    {
        public FontMetrics
        (
            ushort? designUnitsPerEm = null,
            ushort? ascent = null,
            ushort? descent = null,
            short? lineGap = null,
            ushort? capHeight = null,
            ushort? xHeight = null,
            short? underlinePosition = null,
            ushort? underlineThickness = null,
            short? strikethroughPosition = null,
            ushort? strikethroughThickness = null
        ) : this()
        {
            if (designUnitsPerEm is not null)
            {
                DesignUnitsPerEm = designUnitsPerEm.Value;
            }

            if (ascent is not null)
            {
                Ascent = ascent.Value;
            }

            if (descent is not null)
            {
                Descent = descent.Value;
            }

            if (lineGap is not null)
            {
                LineGap = lineGap.Value;
            }

            if (capHeight is not null)
            {
                CapHeight = capHeight.Value;
            }

            if (xHeight is not null)
            {
                XHeight = xHeight.Value;
            }

            if (underlinePosition is not null)
            {
                UnderlinePosition = underlinePosition.Value;
            }

            if (underlineThickness is not null)
            {
                UnderlineThickness = underlineThickness.Value;
            }

            if (strikethroughPosition is not null)
            {
                StrikethroughPosition = strikethroughPosition.Value;
            }

            if (strikethroughThickness is not null)
            {
                StrikethroughThickness = strikethroughThickness.Value;
            }
        }


        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "designUnitsPerEm")]
        public ushort DesignUnitsPerEm;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "ascent")]
        public ushort Ascent;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "descent")]
        public ushort Descent;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "lineGap")]
        public short LineGap;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "capHeight")]
        public ushort CapHeight;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "xHeight")]
        public ushort XHeight;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "underlinePosition")]
        public short UnderlinePosition;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "underlineThickness")]
        public ushort UnderlineThickness;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "strikethroughPosition")]
        public short StrikethroughPosition;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "strikethroughThickness")]
        public ushort StrikethroughThickness;
    }
}
