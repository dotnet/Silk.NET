// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TBSTYLE
{
    [NativeTypeName("#define TBSTYLE_BUTTON 0x0000")]
    public const int TBSTYLE_BUTTON = 0x0000;

    [NativeTypeName("#define TBSTYLE_SEP 0x0001")]
    public const int TBSTYLE_SEP = 0x0001;

    [NativeTypeName("#define TBSTYLE_CHECK 0x0002")]
    public const int TBSTYLE_CHECK = 0x0002;

    [NativeTypeName("#define TBSTYLE_GROUP 0x0004")]
    public const int TBSTYLE_GROUP = 0x0004;

    [NativeTypeName("#define TBSTYLE_CHECKGROUP (TBSTYLE_GROUP | TBSTYLE_CHECK)")]
    public const int TBSTYLE_CHECKGROUP = (0x0004 | 0x0002);

    [NativeTypeName("#define TBSTYLE_DROPDOWN 0x0008")]
    public const int TBSTYLE_DROPDOWN = 0x0008;

    [NativeTypeName("#define TBSTYLE_AUTOSIZE 0x0010")]
    public const int TBSTYLE_AUTOSIZE = 0x0010;

    [NativeTypeName("#define TBSTYLE_NOPREFIX 0x0020")]
    public const int TBSTYLE_NOPREFIX = 0x0020;

    [NativeTypeName("#define TBSTYLE_TOOLTIPS 0x0100")]
    public const int TBSTYLE_TOOLTIPS = 0x0100;

    [NativeTypeName("#define TBSTYLE_WRAPABLE 0x0200")]
    public const int TBSTYLE_WRAPABLE = 0x0200;

    [NativeTypeName("#define TBSTYLE_ALTDRAG 0x0400")]
    public const int TBSTYLE_ALTDRAG = 0x0400;

    [NativeTypeName("#define TBSTYLE_FLAT 0x0800")]
    public const int TBSTYLE_FLAT = 0x0800;

    [NativeTypeName("#define TBSTYLE_LIST 0x1000")]
    public const int TBSTYLE_LIST = 0x1000;

    [NativeTypeName("#define TBSTYLE_CUSTOMERASE 0x2000")]
    public const int TBSTYLE_CUSTOMERASE = 0x2000;

    [NativeTypeName("#define TBSTYLE_REGISTERDROP 0x4000")]
    public const int TBSTYLE_REGISTERDROP = 0x4000;

    [NativeTypeName("#define TBSTYLE_TRANSPARENT 0x8000")]
    public const int TBSTYLE_TRANSPARENT = 0x8000;

    [NativeTypeName("#define TBSTYLE_EX_DRAWDDARROWS 0x00000001")]
    public const int TBSTYLE_EX_DRAWDDARROWS = 0x00000001;

    [NativeTypeName("#define TBSTYLE_EX_MIXEDBUTTONS 0x00000008")]
    public const int TBSTYLE_EX_MIXEDBUTTONS = 0x00000008;

    [NativeTypeName("#define TBSTYLE_EX_HIDECLIPPEDBUTTONS 0x00000010")]
    public const int TBSTYLE_EX_HIDECLIPPEDBUTTONS = 0x00000010;

    [NativeTypeName("#define TBSTYLE_EX_MULTICOLUMN 0x00000002")]
    public const int TBSTYLE_EX_MULTICOLUMN = 0x00000002;

    [NativeTypeName("#define TBSTYLE_EX_VERTICAL 0x00000004")]
    public const int TBSTYLE_EX_VERTICAL = 0x00000004;

    [NativeTypeName("#define TBSTYLE_EX_DOUBLEBUFFER 0x00000080")]
    public const int TBSTYLE_EX_DOUBLEBUFFER = 0x00000080;
}
