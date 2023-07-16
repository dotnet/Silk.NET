// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class LVHT
{
    [NativeTypeName("#define LVHT_NOWHERE 0x00000001")]
    public const int LVHT_NOWHERE = 0x00000001;
    [NativeTypeName("#define LVHT_ONITEMICON 0x00000002")]
    public const int LVHT_ONITEMICON = 0x00000002;
    [NativeTypeName("#define LVHT_ONITEMLABEL 0x00000004")]
    public const int LVHT_ONITEMLABEL = 0x00000004;
    [NativeTypeName("#define LVHT_ONITEMSTATEICON 0x00000008")]
    public const int LVHT_ONITEMSTATEICON = 0x00000008;
    [NativeTypeName("#define LVHT_ONITEM (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON)")]
    public const int LVHT_ONITEM = (0x00000002 | 0x00000004 | 0x00000008);
    [NativeTypeName("#define LVHT_ABOVE 0x00000008")]
    public const int LVHT_ABOVE = 0x00000008;
    [NativeTypeName("#define LVHT_BELOW 0x00000010")]
    public const int LVHT_BELOW = 0x00000010;
    [NativeTypeName("#define LVHT_TORIGHT 0x00000020")]
    public const int LVHT_TORIGHT = 0x00000020;
    [NativeTypeName("#define LVHT_TOLEFT 0x00000040")]
    public const int LVHT_TOLEFT = 0x00000040;
    [NativeTypeName("#define LVHT_EX_GROUP_HEADER 0x10000000")]
    public const int LVHT_EX_GROUP_HEADER = 0x10000000;
    [NativeTypeName("#define LVHT_EX_GROUP_FOOTER 0x20000000")]
    public const int LVHT_EX_GROUP_FOOTER = 0x20000000;
    [NativeTypeName("#define LVHT_EX_GROUP_COLLAPSE 0x40000000")]
    public const int LVHT_EX_GROUP_COLLAPSE = 0x40000000;
    [NativeTypeName("#define LVHT_EX_GROUP_BACKGROUND 0x80000000")]
    public const uint LVHT_EX_GROUP_BACKGROUND = 0x80000000;
    [NativeTypeName("#define LVHT_EX_GROUP_STATEICON 0x01000000")]
    public const int LVHT_EX_GROUP_STATEICON = 0x01000000;
    [NativeTypeName("#define LVHT_EX_GROUP_SUBSETLINK 0x02000000")]
    public const int LVHT_EX_GROUP_SUBSETLINK = 0x02000000;
    [NativeTypeName("#define LVHT_EX_GROUP (LVHT_EX_GROUP_BACKGROUND | LVHT_EX_GROUP_COLLAPSE | LVHT_EX_GROUP_FOOTER | LVHT_EX_GROUP_HEADER | LVHT_EX_GROUP_STATEICON | LVHT_EX_GROUP_SUBSETLINK)")]
    public const uint LVHT_EX_GROUP = (0x80000000 | 0x40000000 | 0x20000000 | 0x10000000 | 0x01000000 | 0x02000000);
    [NativeTypeName("#define LVHT_EX_ONCONTENTS 0x04000000")]
    public const int LVHT_EX_ONCONTENTS = 0x04000000;
    [NativeTypeName("#define LVHT_EX_FOOTER 0x08000000")]
    public const int LVHT_EX_FOOTER = 0x08000000;
}