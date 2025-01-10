// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DWRITE_PAINT_ELEMENT
{
    public DWRITE_PAINT_TYPE paintType;

    [NativeTypeName("union PAINT_UNION")]
    public PAINT_UNION paint;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct PAINT_UNION
    {
        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_LAYERS")]
        public PAINT_LAYERS layers;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_SOLID_GLYPH")]
        public PAINT_SOLID_GLYPH solidGlyph;

        [FieldOffset(0)]
        public DWRITE_PAINT_COLOR solid;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_LINEAR_GRADIENT")]
        public PAINT_LINEAR_GRADIENT linearGradient;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_RADIAL_GRADIENT")]
        public PAINT_RADIAL_GRADIENT radialGradient;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_SWEEP_GRADIENT")]
        public PAINT_SWEEP_GRADIENT sweepGradient;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_GLYPH")]
        public PAINT_GLYPH glyph;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_COLOR_GLYPH")]
        public PAINT_COLOR_GLYPH colorGlyph;

        [FieldOffset(0)]
        public DWRITE_MATRIX transform;

        [FieldOffset(0)]
        [NativeTypeName("struct PAINT_COMPOSITE")]
        public PAINT_COMPOSITE composite;

        public partial struct PAINT_LAYERS
        {
            [NativeTypeName("UINT32")]
            public uint childCount;
        }

        public partial struct PAINT_SOLID_GLYPH
        {
            [NativeTypeName("UINT32")]
            public uint glyphIndex;
            public DWRITE_PAINT_COLOR color;
        }

        public partial struct PAINT_LINEAR_GRADIENT
        {
            [NativeTypeName("UINT32")]
            public uint extendMode;

            [NativeTypeName("UINT32")]
            public uint gradientStopCount;
            public float x0;
            public float y0;
            public float x1;
            public float y1;
            public float x2;
            public float y2;
        }

        public partial struct PAINT_RADIAL_GRADIENT
        {
            [NativeTypeName("UINT32")]
            public uint extendMode;

            [NativeTypeName("UINT32")]
            public uint gradientStopCount;
            public float x0;
            public float y0;
            public float radius0;
            public float x1;
            public float y1;
            public float radius1;
        }

        public partial struct PAINT_SWEEP_GRADIENT
        {
            [NativeTypeName("UINT32")]
            public uint extendMode;

            [NativeTypeName("UINT32")]
            public uint gradientStopCount;
            public float centerX;
            public float centerY;
            public float startAngle;
            public float endAngle;
        }

        public partial struct PAINT_GLYPH
        {
            [NativeTypeName("UINT32")]
            public uint glyphIndex;
        }

        public partial struct PAINT_COLOR_GLYPH
        {
            [NativeTypeName("UINT32")]
            public uint glyphIndex;
            public D2D_RECT_F clipBox;
        }

        public partial struct PAINT_COMPOSITE
        {
            public DWRITE_COLOR_COMPOSITE_MODE mode;
        }
    }
}
