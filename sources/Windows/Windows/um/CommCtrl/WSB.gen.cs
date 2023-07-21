// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class WSB
{
    [NativeTypeName("#define WSB_PROP_CYVSCROLL 0x00000001L")]
    public const int WSB_PROP_CYVSCROLL = 0x00000001;

    [NativeTypeName("#define WSB_PROP_CXHSCROLL 0x00000002L")]
    public const int WSB_PROP_CXHSCROLL = 0x00000002;

    [NativeTypeName("#define WSB_PROP_CYHSCROLL 0x00000004L")]
    public const int WSB_PROP_CYHSCROLL = 0x00000004;

    [NativeTypeName("#define WSB_PROP_CXVSCROLL 0x00000008L")]
    public const int WSB_PROP_CXVSCROLL = 0x00000008;

    [NativeTypeName("#define WSB_PROP_CXHTHUMB 0x00000010L")]
    public const int WSB_PROP_CXHTHUMB = 0x00000010;

    [NativeTypeName("#define WSB_PROP_CYVTHUMB 0x00000020L")]
    public const int WSB_PROP_CYVTHUMB = 0x00000020;

    [NativeTypeName("#define WSB_PROP_VBKGCOLOR 0x00000040L")]
    public const int WSB_PROP_VBKGCOLOR = 0x00000040;

    [NativeTypeName("#define WSB_PROP_HBKGCOLOR 0x00000080L")]
    public const int WSB_PROP_HBKGCOLOR = 0x00000080;

    [NativeTypeName("#define WSB_PROP_VSTYLE 0x00000100L")]
    public const int WSB_PROP_VSTYLE = 0x00000100;

    [NativeTypeName("#define WSB_PROP_HSTYLE 0x00000200L")]
    public const int WSB_PROP_HSTYLE = 0x00000200;

    [NativeTypeName("#define WSB_PROP_WINSTYLE 0x00000400L")]
    public const int WSB_PROP_WINSTYLE = 0x00000400;

    [NativeTypeName("#define WSB_PROP_PALETTE 0x00000800L")]
    public const int WSB_PROP_PALETTE = 0x00000800;

    [NativeTypeName("#define WSB_PROP_MASK 0x00000FFFL")]
    public const int WSB_PROP_MASK = 0x00000FFF;
}
