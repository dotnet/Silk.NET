// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.Gdiplus;
public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsIndexedPixelFormat"]/*'/>
    public static BOOL IsIndexedPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00010000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsAlphaPixelFormat"]/*'/>
    public static BOOL IsAlphaPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00040000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsExtendedPixelFormat"]/*'/>
    public static BOOL IsExtendedPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00100000) != 0) ? 1 : 0;
    }

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.IsCanonicalPixelFormat"]/*'/>
    public static BOOL IsCanonicalPixelFormat([NativeTypeName("Gdiplus::PixelFormat")] int pixfmt)
    {
        return ((pixfmt & 0x00200000) != 0) ? 1 : 0;
    }

    [NativeTypeName("#define ALPHA_SHIFT 24")]
    public const int ALPHA_SHIFT = 24;
    [NativeTypeName("#define RED_SHIFT 16")]
    public const int RED_SHIFT = 16;
    [NativeTypeName("#define GREEN_SHIFT 8")]
    public const int GREEN_SHIFT = 8;
    [NativeTypeName("#define BLUE_SHIFT 0")]
    public const int BLUE_SHIFT = 0;
    [NativeTypeName("#define PixelFormatIndexed 0x00010000")]
    public const int PixelFormatIndexed = 0x00010000;
    [NativeTypeName("#define PixelFormatGDI 0x00020000")]
    public const int PixelFormatGDI = 0x00020000;
    [NativeTypeName("#define PixelFormatAlpha 0x00040000")]
    public const int PixelFormatAlpha = 0x00040000;
    [NativeTypeName("#define PixelFormatPAlpha 0x00080000")]
    public const int PixelFormatPAlpha = 0x00080000;
    [NativeTypeName("#define PixelFormatExtended 0x00100000")]
    public const int PixelFormatExtended = 0x00100000;
    [NativeTypeName("#define PixelFormatCanonical 0x00200000")]
    public const int PixelFormatCanonical = 0x00200000;
    [NativeTypeName("#define PixelFormatUndefined 0")]
    public const int PixelFormatUndefined = 0;
    [NativeTypeName("#define PixelFormatDontCare 0")]
    public const int PixelFormatDontCare = 0;
    [NativeTypeName("#define PixelFormat1bppIndexed (1 | ( 1 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat1bppIndexed = (1 | (1 << 8) | 0x00010000 | 0x00020000);
    [NativeTypeName("#define PixelFormat4bppIndexed (2 | ( 4 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat4bppIndexed = (2 | (4 << 8) | 0x00010000 | 0x00020000);
    [NativeTypeName("#define PixelFormat8bppIndexed (3 | ( 8 << 8) | PixelFormatIndexed | PixelFormatGDI)")]
    public const int PixelFormat8bppIndexed = (3 | (8 << 8) | 0x00010000 | 0x00020000);
    [NativeTypeName("#define PixelFormat16bppGrayScale (4 | (16 << 8) | PixelFormatExtended)")]
    public const int PixelFormat16bppGrayScale = (4 | (16 << 8) | 0x00100000);
    [NativeTypeName("#define PixelFormat16bppRGB555 (5 | (16 << 8) | PixelFormatGDI)")]
    public const int PixelFormat16bppRGB555 = (5 | (16 << 8) | 0x00020000);
    [NativeTypeName("#define PixelFormat16bppRGB565 (6 | (16 << 8) | PixelFormatGDI)")]
    public const int PixelFormat16bppRGB565 = (6 | (16 << 8) | 0x00020000);
    [NativeTypeName("#define PixelFormat16bppARGB1555 (7 | (16 << 8) | PixelFormatAlpha | PixelFormatGDI)")]
    public const int PixelFormat16bppARGB1555 = (7 | (16 << 8) | 0x00040000 | 0x00020000);
    [NativeTypeName("#define PixelFormat24bppRGB (8 | (24 << 8) | PixelFormatGDI)")]
    public const int PixelFormat24bppRGB = (8 | (24 << 8) | 0x00020000);
    [NativeTypeName("#define PixelFormat32bppRGB (9 | (32 << 8) | PixelFormatGDI)")]
    public const int PixelFormat32bppRGB = (9 | (32 << 8) | 0x00020000);
    [NativeTypeName("#define PixelFormat32bppARGB (10 | (32 << 8) | PixelFormatAlpha | PixelFormatGDI | PixelFormatCanonical)")]
    public const int PixelFormat32bppARGB = (10 | (32 << 8) | 0x00040000 | 0x00020000 | 0x00200000);
    [NativeTypeName("#define PixelFormat32bppPARGB (11 | (32 << 8) | PixelFormatAlpha | PixelFormatPAlpha | PixelFormatGDI)")]
    public const int PixelFormat32bppPARGB = (11 | (32 << 8) | 0x00040000 | 0x00080000 | 0x00020000);
    [NativeTypeName("#define PixelFormat48bppRGB (12 | (48 << 8) | PixelFormatExtended)")]
    public const int PixelFormat48bppRGB = (12 | (48 << 8) | 0x00100000);
    [NativeTypeName("#define PixelFormat64bppARGB (13 | (64 << 8) | PixelFormatAlpha  | PixelFormatCanonical | PixelFormatExtended)")]
    public const int PixelFormat64bppARGB = (13 | (64 << 8) | 0x00040000 | 0x00200000 | 0x00100000);
    [NativeTypeName("#define PixelFormat64bppPARGB (14 | (64 << 8) | PixelFormatAlpha  | PixelFormatPAlpha | PixelFormatExtended)")]
    public const int PixelFormat64bppPARGB = (14 | (64 << 8) | 0x00040000 | 0x00080000 | 0x00100000);
    [NativeTypeName("#define PixelFormat32bppCMYK (15 | (32 << 8))")]
    public const int PixelFormat32bppCMYK = (15 | (32 << 8));
    [NativeTypeName("#define PixelFormatMax 16")]
    public const int PixelFormatMax = 16;
}