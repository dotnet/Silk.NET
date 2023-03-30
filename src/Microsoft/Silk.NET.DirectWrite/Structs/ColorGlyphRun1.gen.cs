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
    [NativeName("Name", "DWRITE_COLOR_GLYPH_RUN1")]
    public unsafe partial struct ColorGlyphRun1
    {
        public ColorGlyphRun1
        (
            GlyphRun? glyphRun = null,
            GlyphRunDescription* glyphRunDescription = null,
            float? baselineOriginX = null,
            float? baselineOriginY = null,
            Silk.NET.DXGI.D3Dcolorvalue? runColor = null,
            ushort? paletteIndex = null,
            GlyphImageFormats? glyphImageFormat = null,
            MeasuringMode? measuringMode = null
        ) : this()
        {
            if (glyphRun is not null)
            {
                GlyphRun = glyphRun.Value;
            }

            if (glyphRunDescription is not null)
            {
                GlyphRunDescription = glyphRunDescription;
            }

            if (baselineOriginX is not null)
            {
                BaselineOriginX = baselineOriginX.Value;
            }

            if (baselineOriginY is not null)
            {
                BaselineOriginY = baselineOriginY.Value;
            }

            if (runColor is not null)
            {
                RunColor = runColor.Value;
            }

            if (paletteIndex is not null)
            {
                PaletteIndex = paletteIndex.Value;
            }

            if (glyphImageFormat is not null)
            {
                GlyphImageFormat = glyphImageFormat.Value;
            }

            if (measuringMode is not null)
            {
                MeasuringMode = measuringMode.Value;
            }
        }


        [NativeName("Type", "DWRITE_GLYPH_RUN")]
        [NativeName("Type.Name", "DWRITE_GLYPH_RUN")]
        [NativeName("Name", "glyphRun")]
        public GlyphRun GlyphRun;

        [NativeName("Type", "DWRITE_GLYPH_RUN_DESCRIPTION *")]
        [NativeName("Type.Name", "DWRITE_GLYPH_RUN_DESCRIPTION *")]
        [NativeName("Name", "glyphRunDescription")]
        public GlyphRunDescription* GlyphRunDescription;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "baselineOriginX")]
        public float BaselineOriginX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "baselineOriginY")]
        public float BaselineOriginY;

        [NativeName("Type", "DWRITE_COLOR_F")]
        [NativeName("Type.Name", "DWRITE_COLOR_F")]
        [NativeName("Name", "runColor")]
        public Silk.NET.DXGI.D3Dcolorvalue RunColor;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "paletteIndex")]
        public ushort PaletteIndex;

        [NativeName("Type", "DWRITE_GLYPH_IMAGE_FORMATS")]
        [NativeName("Type.Name", "DWRITE_GLYPH_IMAGE_FORMATS")]
        [NativeName("Name", "glyphImageFormat")]
        public GlyphImageFormats GlyphImageFormat;

        [NativeName("Type", "DWRITE_MEASURING_MODE")]
        [NativeName("Type.Name", "DWRITE_MEASURING_MODE")]
        [NativeName("Name", "measuringMode")]
        public MeasuringMode MeasuringMode;
    }
}
