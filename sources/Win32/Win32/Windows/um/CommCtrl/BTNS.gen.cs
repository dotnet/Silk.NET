// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class BTNS
{
    [NativeTypeName("#define BTNS_BUTTON TBSTYLE_BUTTON")]
    public const int BTNS_BUTTON = 0x0000;

    [NativeTypeName("#define BTNS_SEP TBSTYLE_SEP")]
    public const int BTNS_SEP = 0x0001;

    [NativeTypeName("#define BTNS_CHECK TBSTYLE_CHECK")]
    public const int BTNS_CHECK = 0x0002;

    [NativeTypeName("#define BTNS_GROUP TBSTYLE_GROUP")]
    public const int BTNS_GROUP = 0x0004;

    [NativeTypeName("#define BTNS_CHECKGROUP TBSTYLE_CHECKGROUP")]
    public const int BTNS_CHECKGROUP = (0x0004 | 0x0002);

    [NativeTypeName("#define BTNS_DROPDOWN TBSTYLE_DROPDOWN")]
    public const int BTNS_DROPDOWN = 0x0008;

    [NativeTypeName("#define BTNS_AUTOSIZE TBSTYLE_AUTOSIZE")]
    public const int BTNS_AUTOSIZE = 0x0010;

    [NativeTypeName("#define BTNS_NOPREFIX TBSTYLE_NOPREFIX")]
    public const int BTNS_NOPREFIX = 0x0020;

    [NativeTypeName("#define BTNS_SHOWTEXT 0x0040")]
    public const int BTNS_SHOWTEXT = 0x0040;

    [NativeTypeName("#define BTNS_WHOLEDROPDOWN 0x0080")]
    public const int BTNS_WHOLEDROPDOWN = 0x0080;
}
