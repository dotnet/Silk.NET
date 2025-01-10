// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public enum PaletteType
{
    PaletteTypeCustom = 0,
    PaletteTypeOptimal = 1,
    PaletteTypeFixedBW = 2,
    PaletteTypeFixedHalftone8 = 3,
    PaletteTypeFixedHalftone27 = 4,
    PaletteTypeFixedHalftone64 = 5,
    PaletteTypeFixedHalftone125 = 6,
    PaletteTypeFixedHalftone216 = 7,
    PaletteTypeFixedHalftone252 = 8,
    PaletteTypeFixedHalftone256 = 9,
}
