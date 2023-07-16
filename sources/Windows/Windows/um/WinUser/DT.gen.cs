// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DT
{
    [NativeTypeName("#define DT_TOP 0x00000000")]
    public const int DT_TOP = 0x00000000;
    [NativeTypeName("#define DT_LEFT 0x00000000")]
    public const int DT_LEFT = 0x00000000;
    [NativeTypeName("#define DT_CENTER 0x00000001")]
    public const int DT_CENTER = 0x00000001;
    [NativeTypeName("#define DT_RIGHT 0x00000002")]
    public const int DT_RIGHT = 0x00000002;
    [NativeTypeName("#define DT_VCENTER 0x00000004")]
    public const int DT_VCENTER = 0x00000004;
    [NativeTypeName("#define DT_BOTTOM 0x00000008")]
    public const int DT_BOTTOM = 0x00000008;
    [NativeTypeName("#define DT_WORDBREAK 0x00000010")]
    public const int DT_WORDBREAK = 0x00000010;
    [NativeTypeName("#define DT_SINGLELINE 0x00000020")]
    public const int DT_SINGLELINE = 0x00000020;
    [NativeTypeName("#define DT_EXPANDTABS 0x00000040")]
    public const int DT_EXPANDTABS = 0x00000040;
    [NativeTypeName("#define DT_TABSTOP 0x00000080")]
    public const int DT_TABSTOP = 0x00000080;
    [NativeTypeName("#define DT_NOCLIP 0x00000100")]
    public const int DT_NOCLIP = 0x00000100;
    [NativeTypeName("#define DT_EXTERNALLEADING 0x00000200")]
    public const int DT_EXTERNALLEADING = 0x00000200;
    [NativeTypeName("#define DT_CALCRECT 0x00000400")]
    public const int DT_CALCRECT = 0x00000400;
    [NativeTypeName("#define DT_NOPREFIX 0x00000800")]
    public const int DT_NOPREFIX = 0x00000800;
    [NativeTypeName("#define DT_INTERNAL 0x00001000")]
    public const int DT_INTERNAL = 0x00001000;
    [NativeTypeName("#define DT_EDITCONTROL 0x00002000")]
    public const int DT_EDITCONTROL = 0x00002000;
    [NativeTypeName("#define DT_PATH_ELLIPSIS 0x00004000")]
    public const int DT_PATH_ELLIPSIS = 0x00004000;
    [NativeTypeName("#define DT_END_ELLIPSIS 0x00008000")]
    public const int DT_END_ELLIPSIS = 0x00008000;
    [NativeTypeName("#define DT_MODIFYSTRING 0x00010000")]
    public const int DT_MODIFYSTRING = 0x00010000;
    [NativeTypeName("#define DT_RTLREADING 0x00020000")]
    public const int DT_RTLREADING = 0x00020000;
    [NativeTypeName("#define DT_WORD_ELLIPSIS 0x00040000")]
    public const int DT_WORD_ELLIPSIS = 0x00040000;
    [NativeTypeName("#define DT_NOFULLWIDTHCHARBREAK 0x00080000")]
    public const int DT_NOFULLWIDTHCHARBREAK = 0x00080000;
    [NativeTypeName("#define DT_HIDEPREFIX 0x00100000")]
    public const int DT_HIDEPREFIX = 0x00100000;
    [NativeTypeName("#define DT_PREFIXONLY 0x00200000")]
    public const int DT_PREFIXONLY = 0x00200000;
}