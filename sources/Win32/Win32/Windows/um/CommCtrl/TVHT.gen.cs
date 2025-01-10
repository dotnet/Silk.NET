// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TVHT
{
    [NativeTypeName("#define TVHT_NOWHERE 0x0001")]
    public const int TVHT_NOWHERE = 0x0001;

    [NativeTypeName("#define TVHT_ONITEMICON 0x0002")]
    public const int TVHT_ONITEMICON = 0x0002;

    [NativeTypeName("#define TVHT_ONITEMLABEL 0x0004")]
    public const int TVHT_ONITEMLABEL = 0x0004;

    [NativeTypeName(
        "#define TVHT_ONITEM (TVHT_ONITEMICON | TVHT_ONITEMLABEL | TVHT_ONITEMSTATEICON)"
    )]
    public const int TVHT_ONITEM = (0x0002 | 0x0004 | 0x0040);

    [NativeTypeName("#define TVHT_ONITEMINDENT 0x0008")]
    public const int TVHT_ONITEMINDENT = 0x0008;

    [NativeTypeName("#define TVHT_ONITEMBUTTON 0x0010")]
    public const int TVHT_ONITEMBUTTON = 0x0010;

    [NativeTypeName("#define TVHT_ONITEMRIGHT 0x0020")]
    public const int TVHT_ONITEMRIGHT = 0x0020;

    [NativeTypeName("#define TVHT_ONITEMSTATEICON 0x0040")]
    public const int TVHT_ONITEMSTATEICON = 0x0040;

    [NativeTypeName("#define TVHT_ABOVE 0x0100")]
    public const int TVHT_ABOVE = 0x0100;

    [NativeTypeName("#define TVHT_BELOW 0x0200")]
    public const int TVHT_BELOW = 0x0200;

    [NativeTypeName("#define TVHT_TORIGHT 0x0400")]
    public const int TVHT_TORIGHT = 0x0400;

    [NativeTypeName("#define TVHT_TOLEFT 0x0800")]
    public const int TVHT_TOLEFT = 0x0800;
}
