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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "PAINT_UNION")]
    public unsafe partial struct PaintUnion
    {
        public PaintUnion
        (
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_LAYERS? layers = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_SOLID_GLYPH? solidGlyph = null,
            PaintColor? solid = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_LINEAR_GRADIENT? linearGradient = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_RADIAL_GRADIENT? radialGradient = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_SWEEP_GRADIENT? sweepGradient = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_GLYPH? glyph = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_COLOR_GLYPH? colorGlyph = null,
            Matrix? transform = null,
            DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_COMPOSITE? composite = null
        ) : this()
        {
            if (layers is not null)
            {
                Layers = layers.Value;
            }

            if (solidGlyph is not null)
            {
                SolidGlyph = solidGlyph.Value;
            }

            if (solid is not null)
            {
                Solid = solid.Value;
            }

            if (linearGradient is not null)
            {
                LinearGradient = linearGradient.Value;
            }

            if (radialGradient is not null)
            {
                RadialGradient = radialGradient.Value;
            }

            if (sweepGradient is not null)
            {
                SweepGradient = sweepGradient.Value;
            }

            if (glyph is not null)
            {
                Glyph = glyph.Value;
            }

            if (colorGlyph is not null)
            {
                ColorGlyph = colorGlyph.Value;
            }

            if (transform is not null)
            {
                Transform = transform.Value;
            }

            if (composite is not null)
            {
                Composite = composite.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_LAYERS")]
        [NativeName("Type.Name", "struct PAINT_LAYERS")]
        [NativeName("Name", "layers")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_LAYERS Layers;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_SOLID_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_SOLID_GLYPH")]
        [NativeName("Name", "solidGlyph")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_SOLID_GLYPH SolidGlyph;

        [FieldOffset(0)]
        [NativeName("Type", "DWRITE_PAINT_COLOR")]
        [NativeName("Type.Name", "DWRITE_PAINT_COLOR")]
        [NativeName("Name", "solid")]
        public PaintColor Solid;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_LINEAR_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_LINEAR_GRADIENT")]
        [NativeName("Name", "linearGradient")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_LINEAR_GRADIENT LinearGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_RADIAL_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_RADIAL_GRADIENT")]
        [NativeName("Name", "radialGradient")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_RADIAL_GRADIENT RadialGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_SWEEP_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_SWEEP_GRADIENT")]
        [NativeName("Name", "sweepGradient")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_SWEEP_GRADIENT SweepGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_GLYPH")]
        [NativeName("Name", "glyph")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_GLYPH Glyph;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_COLOR_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_COLOR_GLYPH")]
        [NativeName("Name", "colorGlyph")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_COLOR_GLYPH ColorGlyph;

        [FieldOffset(0)]
        [NativeName("Type", "DWRITE_MATRIX")]
        [NativeName("Type.Name", "DWRITE_MATRIX")]
        [NativeName("Name", "transform")]
        public Matrix Transform;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_COMPOSITE")]
        [NativeName("Type.Name", "struct PAINT_COMPOSITE")]
        [NativeName("Name", "composite")]
        public DWRITE_PAINT_ELEMENT::PAINT_UNION::PAINT_COMPOSITE Composite;
    }
}
