// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class TCS
{
    [NativeTypeName("#define TCS_SCROLLOPPOSITE 0x0001")]
    public const int TCS_SCROLLOPPOSITE = 0x0001;
    [NativeTypeName("#define TCS_BOTTOM 0x0002")]
    public const int TCS_BOTTOM = 0x0002;
    [NativeTypeName("#define TCS_RIGHT 0x0002")]
    public const int TCS_RIGHT = 0x0002;
    [NativeTypeName("#define TCS_MULTISELECT 0x0004")]
    public const int TCS_MULTISELECT = 0x0004;
    [NativeTypeName("#define TCS_FLATBUTTONS 0x0008")]
    public const int TCS_FLATBUTTONS = 0x0008;
    [NativeTypeName("#define TCS_FORCEICONLEFT 0x0010")]
    public const int TCS_FORCEICONLEFT = 0x0010;
    [NativeTypeName("#define TCS_FORCELABELLEFT 0x0020")]
    public const int TCS_FORCELABELLEFT = 0x0020;
    [NativeTypeName("#define TCS_HOTTRACK 0x0040")]
    public const int TCS_HOTTRACK = 0x0040;
    [NativeTypeName("#define TCS_VERTICAL 0x0080")]
    public const int TCS_VERTICAL = 0x0080;
    [NativeTypeName("#define TCS_TABS 0x0000")]
    public const int TCS_TABS = 0x0000;
    [NativeTypeName("#define TCS_BUTTONS 0x0100")]
    public const int TCS_BUTTONS = 0x0100;
    [NativeTypeName("#define TCS_SINGLELINE 0x0000")]
    public const int TCS_SINGLELINE = 0x0000;
    [NativeTypeName("#define TCS_MULTILINE 0x0200")]
    public const int TCS_MULTILINE = 0x0200;
    [NativeTypeName("#define TCS_RIGHTJUSTIFY 0x0000")]
    public const int TCS_RIGHTJUSTIFY = 0x0000;
    [NativeTypeName("#define TCS_FIXEDWIDTH 0x0400")]
    public const int TCS_FIXEDWIDTH = 0x0400;
    [NativeTypeName("#define TCS_RAGGEDRIGHT 0x0800")]
    public const int TCS_RAGGEDRIGHT = 0x0800;
    [NativeTypeName("#define TCS_FOCUSONBUTTONDOWN 0x1000")]
    public const int TCS_FOCUSONBUTTONDOWN = 0x1000;
    [NativeTypeName("#define TCS_OWNERDRAWFIXED 0x2000")]
    public const int TCS_OWNERDRAWFIXED = 0x2000;
    [NativeTypeName("#define TCS_TOOLTIPS 0x4000")]
    public const int TCS_TOOLTIPS = 0x4000;
    [NativeTypeName("#define TCS_FOCUSNEVER 0x8000")]
    public const int TCS_FOCUSNEVER = 0x8000;
    [NativeTypeName("#define TCS_EX_FLATSEPARATORS 0x00000001")]
    public const int TCS_EX_FLATSEPARATORS = 0x00000001;
    [NativeTypeName("#define TCS_EX_REGISTERDROP 0x00000002")]
    public const int TCS_EX_REGISTERDROP = 0x00000002;
}