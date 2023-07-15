// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DTT
{
    [NativeTypeName("#define DTT_GRAYED 0x00000001")]
    public const int DTT_GRAYED = 0x00000001;
    [NativeTypeName("#define DTT_FLAGS2VALIDBITS (DTT_GRAYED)")]
    public const int DTT_FLAGS2VALIDBITS = (0x00000001);
    [NativeTypeName("#define DTT_TEXTCOLOR (1UL << 0)")]
    public const uint DTT_TEXTCOLOR = (1U << 0);
    [NativeTypeName("#define DTT_BORDERCOLOR (1UL << 1)")]
    public const uint DTT_BORDERCOLOR = (1U << 1);
    [NativeTypeName("#define DTT_SHADOWCOLOR (1UL << 2)")]
    public const uint DTT_SHADOWCOLOR = (1U << 2);
    [NativeTypeName("#define DTT_SHADOWTYPE (1UL << 3)")]
    public const uint DTT_SHADOWTYPE = (1U << 3);
    [NativeTypeName("#define DTT_SHADOWOFFSET (1UL << 4)")]
    public const uint DTT_SHADOWOFFSET = (1U << 4);
    [NativeTypeName("#define DTT_BORDERSIZE (1UL << 5)")]
    public const uint DTT_BORDERSIZE = (1U << 5);
    [NativeTypeName("#define DTT_FONTPROP (1UL << 6)")]
    public const uint DTT_FONTPROP = (1U << 6);
    [NativeTypeName("#define DTT_COLORPROP (1UL << 7)")]
    public const uint DTT_COLORPROP = (1U << 7);
    [NativeTypeName("#define DTT_STATEID (1UL << 8)")]
    public const uint DTT_STATEID = (1U << 8);
    [NativeTypeName("#define DTT_CALCRECT (1UL << 9)")]
    public const uint DTT_CALCRECT = (1U << 9);
    [NativeTypeName("#define DTT_APPLYOVERLAY (1UL << 10)")]
    public const uint DTT_APPLYOVERLAY = (1U << 10);
    [NativeTypeName("#define DTT_GLOWSIZE (1UL << 11)")]
    public const uint DTT_GLOWSIZE = (1U << 11);
    [NativeTypeName("#define DTT_CALLBACK (1UL << 12)")]
    public const uint DTT_CALLBACK = (1U << 12);
    [NativeTypeName("#define DTT_COMPOSITED (1UL << 13)")]
    public const uint DTT_COMPOSITED = (1U << 13);
    [NativeTypeName("#define DTT_VALIDBITS (DTT_TEXTCOLOR | \\\r\n                             DTT_BORDERCOLOR | \\\r\n                             DTT_SHADOWCOLOR | \\\r\n                             DTT_SHADOWTYPE | \\\r\n                             DTT_SHADOWOFFSET | \\\r\n                             DTT_BORDERSIZE | \\\r\n                             DTT_FONTPROP | \\\r\n                             DTT_COLORPROP | \\\r\n                             DTT_STATEID | \\\r\n                             DTT_CALCRECT | \\\r\n                             DTT_APPLYOVERLAY | \\\r\n                             DTT_GLOWSIZE | \\\r\n                             DTT_COMPOSITED)")]
    public const uint DTT_VALIDBITS = ((1U << 0) | (1U << 1) | (1U << 2) | (1U << 3) | (1U << 4) | (1U << 5) | (1U << 6) | (1U << 7) | (1U << 8) | (1U << 9) | (1U << 10) | (1U << 11) | (1U << 13));
}