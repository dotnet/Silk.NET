// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PAINT_TYPE
{
    DWRITE_PAINT_TYPE_NONE,
    DWRITE_PAINT_TYPE_LAYERS,
    DWRITE_PAINT_TYPE_SOLID_GLYPH,
    DWRITE_PAINT_TYPE_SOLID,
    DWRITE_PAINT_TYPE_LINEAR_GRADIENT,
    DWRITE_PAINT_TYPE_RADIAL_GRADIENT,
    DWRITE_PAINT_TYPE_SWEEP_GRADIENT,
    DWRITE_PAINT_TYPE_GLYPH,
    DWRITE_PAINT_TYPE_COLOR_GLYPH,
    DWRITE_PAINT_TYPE_TRANSFORM,
    DWRITE_PAINT_TYPE_COMPOSITE,
}
