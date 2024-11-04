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
    [NativeName("Name", "DWRITE_PAINT_COLOR")]
    public unsafe partial struct PaintColor
    {
        public PaintColor
        (
            Silk.NET.DXGI.D3Dcolorvalue? value = null,
            ushort? paletteEntryIndex = null,
            float? alphaMultiplier = null,
            PaintAttributes? colorAttributes = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }

            if (paletteEntryIndex is not null)
            {
                PaletteEntryIndex = paletteEntryIndex.Value;
            }

            if (alphaMultiplier is not null)
            {
                AlphaMultiplier = alphaMultiplier.Value;
            }

            if (colorAttributes is not null)
            {
                ColorAttributes = colorAttributes.Value;
            }
        }


        [NativeName("Type", "DWRITE_COLOR_F")]
        [NativeName("Type.Name", "DWRITE_COLOR_F")]
        [NativeName("Name", "value")]
        public Silk.NET.DXGI.D3Dcolorvalue Value;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "paletteEntryIndex")]
        public ushort PaletteEntryIndex;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "alphaMultiplier")]
        public float AlphaMultiplier;

        [NativeName("Type", "DWRITE_PAINT_ATTRIBUTES")]
        [NativeName("Type.Name", "DWRITE_PAINT_ATTRIBUTES")]
        [NativeName("Name", "colorAttributes")]
        public PaintAttributes ColorAttributes;
    }
}
