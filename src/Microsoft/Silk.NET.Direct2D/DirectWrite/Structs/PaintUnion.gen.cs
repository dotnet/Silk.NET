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
            PaintLayers? layers = null,
            PaintSolidGlyph? solidGlyph = null,
            PaintColor? solid = null,
            PaintLinearGradient? linearGradient = null,
            PaintRadialGradient? radialGradient = null,
            PaintSweepGradient? sweepGradient = null,
            PaintGlyph? glyph = null,
            PaintColorGlyph? colorGlyph = null,
            Matrix? transform = null,
            PaintComposite? composite = null
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
        public PaintLayers Layers;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_SOLID_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_SOLID_GLYPH")]
        [NativeName("Name", "solidGlyph")]
        public PaintSolidGlyph SolidGlyph;

        [FieldOffset(0)]
        [NativeName("Type", "DWRITE_PAINT_COLOR")]
        [NativeName("Type.Name", "DWRITE_PAINT_COLOR")]
        [NativeName("Name", "solid")]
        public PaintColor Solid;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_LINEAR_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_LINEAR_GRADIENT")]
        [NativeName("Name", "linearGradient")]
        public PaintLinearGradient LinearGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_RADIAL_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_RADIAL_GRADIENT")]
        [NativeName("Name", "radialGradient")]
        public PaintRadialGradient RadialGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_SWEEP_GRADIENT")]
        [NativeName("Type.Name", "struct PAINT_SWEEP_GRADIENT")]
        [NativeName("Name", "sweepGradient")]
        public PaintSweepGradient SweepGradient;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_GLYPH")]
        [NativeName("Name", "glyph")]
        public PaintGlyph Glyph;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_COLOR_GLYPH")]
        [NativeName("Type.Name", "struct PAINT_COLOR_GLYPH")]
        [NativeName("Name", "colorGlyph")]
        public PaintColorGlyph ColorGlyph;

        [FieldOffset(0)]
        [NativeName("Type", "DWRITE_MATRIX")]
        [NativeName("Type.Name", "DWRITE_MATRIX")]
        [NativeName("Name", "transform")]
        public Matrix Transform;

        [FieldOffset(0)]
        [NativeName("Type", "struct PAINT_COMPOSITE")]
        [NativeName("Type.Name", "struct PAINT_COMPOSITE")]
        [NativeName("Name", "composite")]
        public PaintComposite Composite;
    }
}
