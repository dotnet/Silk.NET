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
    [NativeName("Name", "DWRITE_FONT_METRICS1")]
    public unsafe partial struct FontMetrics1
    {
        public FontMetrics1
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
            ushort? strikethroughThickness = null,
            short? glyphBoxLeft = null,
            short? glyphBoxTop = null,
            short? glyphBoxRight = null,
            short? glyphBoxBottom = null,
            short? subscriptPositionX = null,
            short? subscriptPositionY = null,
            short? subscriptSizeX = null,
            short? subscriptSizeY = null,
            short? superscriptPositionX = null,
            short? superscriptPositionY = null,
            short? superscriptSizeX = null,
            short? superscriptSizeY = null,
            Silk.NET.Core.Bool32? hasTypographicMetrics = null
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

            if (glyphBoxLeft is not null)
            {
                GlyphBoxLeft = glyphBoxLeft.Value;
            }

            if (glyphBoxTop is not null)
            {
                GlyphBoxTop = glyphBoxTop.Value;
            }

            if (glyphBoxRight is not null)
            {
                GlyphBoxRight = glyphBoxRight.Value;
            }

            if (glyphBoxBottom is not null)
            {
                GlyphBoxBottom = glyphBoxBottom.Value;
            }

            if (subscriptPositionX is not null)
            {
                SubscriptPositionX = subscriptPositionX.Value;
            }

            if (subscriptPositionY is not null)
            {
                SubscriptPositionY = subscriptPositionY.Value;
            }

            if (subscriptSizeX is not null)
            {
                SubscriptSizeX = subscriptSizeX.Value;
            }

            if (subscriptSizeY is not null)
            {
                SubscriptSizeY = subscriptSizeY.Value;
            }

            if (superscriptPositionX is not null)
            {
                SuperscriptPositionX = superscriptPositionX.Value;
            }

            if (superscriptPositionY is not null)
            {
                SuperscriptPositionY = superscriptPositionY.Value;
            }

            if (superscriptSizeX is not null)
            {
                SuperscriptSizeX = superscriptSizeX.Value;
            }

            if (superscriptSizeY is not null)
            {
                SuperscriptSizeY = superscriptSizeY.Value;
            }

            if (hasTypographicMetrics is not null)
            {
                HasTypographicMetrics = hasTypographicMetrics.Value;
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

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "glyphBoxLeft")]
        public short GlyphBoxLeft;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "glyphBoxTop")]
        public short GlyphBoxTop;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "glyphBoxRight")]
        public short GlyphBoxRight;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "glyphBoxBottom")]
        public short GlyphBoxBottom;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "subscriptPositionX")]
        public short SubscriptPositionX;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "subscriptPositionY")]
        public short SubscriptPositionY;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "subscriptSizeX")]
        public short SubscriptSizeX;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "subscriptSizeY")]
        public short SubscriptSizeY;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "superscriptPositionX")]
        public short SuperscriptPositionX;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "superscriptPositionY")]
        public short SuperscriptPositionY;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "superscriptSizeX")]
        public short SuperscriptSizeX;

        [NativeName("Type", "INT16")]
        [NativeName("Type.Name", "INT16")]
        [NativeName("Name", "superscriptSizeY")]
        public short SuperscriptSizeY;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "hasTypographicMetrics")]
        public Silk.NET.Core.Bool32 HasTypographicMetrics;
    }
}
