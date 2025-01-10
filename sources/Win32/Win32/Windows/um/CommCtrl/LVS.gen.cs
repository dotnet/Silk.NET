// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LVS
{
    [NativeTypeName("#define LVS_ICON 0x0000")]
    public const int LVS_ICON = 0x0000;

    [NativeTypeName("#define LVS_REPORT 0x0001")]
    public const int LVS_REPORT = 0x0001;

    [NativeTypeName("#define LVS_SMALLICON 0x0002")]
    public const int LVS_SMALLICON = 0x0002;

    [NativeTypeName("#define LVS_LIST 0x0003")]
    public const int LVS_LIST = 0x0003;

    [NativeTypeName("#define LVS_TYPEMASK 0x0003")]
    public const int LVS_TYPEMASK = 0x0003;

    [NativeTypeName("#define LVS_SINGLESEL 0x0004")]
    public const int LVS_SINGLESEL = 0x0004;

    [NativeTypeName("#define LVS_SHOWSELALWAYS 0x0008")]
    public const int LVS_SHOWSELALWAYS = 0x0008;

    [NativeTypeName("#define LVS_SORTASCENDING 0x0010")]
    public const int LVS_SORTASCENDING = 0x0010;

    [NativeTypeName("#define LVS_SORTDESCENDING 0x0020")]
    public const int LVS_SORTDESCENDING = 0x0020;

    [NativeTypeName("#define LVS_SHAREIMAGELISTS 0x0040")]
    public const int LVS_SHAREIMAGELISTS = 0x0040;

    [NativeTypeName("#define LVS_NOLABELWRAP 0x0080")]
    public const int LVS_NOLABELWRAP = 0x0080;

    [NativeTypeName("#define LVS_AUTOARRANGE 0x0100")]
    public const int LVS_AUTOARRANGE = 0x0100;

    [NativeTypeName("#define LVS_EDITLABELS 0x0200")]
    public const int LVS_EDITLABELS = 0x0200;

    [NativeTypeName("#define LVS_OWNERDATA 0x1000")]
    public const int LVS_OWNERDATA = 0x1000;

    [NativeTypeName("#define LVS_NOSCROLL 0x2000")]
    public const int LVS_NOSCROLL = 0x2000;

    [NativeTypeName("#define LVS_TYPESTYLEMASK 0xfc00")]
    public const int LVS_TYPESTYLEMASK = 0xfc00;

    [NativeTypeName("#define LVS_ALIGNTOP 0x0000")]
    public const int LVS_ALIGNTOP = 0x0000;

    [NativeTypeName("#define LVS_ALIGNLEFT 0x0800")]
    public const int LVS_ALIGNLEFT = 0x0800;

    [NativeTypeName("#define LVS_ALIGNMASK 0x0c00")]
    public const int LVS_ALIGNMASK = 0x0c00;

    [NativeTypeName("#define LVS_OWNERDRAWFIXED 0x0400")]
    public const int LVS_OWNERDRAWFIXED = 0x0400;

    [NativeTypeName("#define LVS_NOCOLUMNHEADER 0x4000")]
    public const int LVS_NOCOLUMNHEADER = 0x4000;

    [NativeTypeName("#define LVS_NOSORTHEADER 0x8000")]
    public const int LVS_NOSORTHEADER = 0x8000;

    [NativeTypeName("#define LVS_EX_GRIDLINES 0x00000001")]
    public const int LVS_EX_GRIDLINES = 0x00000001;

    [NativeTypeName("#define LVS_EX_SUBITEMIMAGES 0x00000002")]
    public const int LVS_EX_SUBITEMIMAGES = 0x00000002;

    [NativeTypeName("#define LVS_EX_CHECKBOXES 0x00000004")]
    public const int LVS_EX_CHECKBOXES = 0x00000004;

    [NativeTypeName("#define LVS_EX_TRACKSELECT 0x00000008")]
    public const int LVS_EX_TRACKSELECT = 0x00000008;

    [NativeTypeName("#define LVS_EX_HEADERDRAGDROP 0x00000010")]
    public const int LVS_EX_HEADERDRAGDROP = 0x00000010;

    [NativeTypeName("#define LVS_EX_FULLROWSELECT 0x00000020")]
    public const int LVS_EX_FULLROWSELECT = 0x00000020;

    [NativeTypeName("#define LVS_EX_ONECLICKACTIVATE 0x00000040")]
    public const int LVS_EX_ONECLICKACTIVATE = 0x00000040;

    [NativeTypeName("#define LVS_EX_TWOCLICKACTIVATE 0x00000080")]
    public const int LVS_EX_TWOCLICKACTIVATE = 0x00000080;

    [NativeTypeName("#define LVS_EX_FLATSB 0x00000100")]
    public const int LVS_EX_FLATSB = 0x00000100;

    [NativeTypeName("#define LVS_EX_REGIONAL 0x00000200")]
    public const int LVS_EX_REGIONAL = 0x00000200;

    [NativeTypeName("#define LVS_EX_INFOTIP 0x00000400")]
    public const int LVS_EX_INFOTIP = 0x00000400;

    [NativeTypeName("#define LVS_EX_UNDERLINEHOT 0x00000800")]
    public const int LVS_EX_UNDERLINEHOT = 0x00000800;

    [NativeTypeName("#define LVS_EX_UNDERLINECOLD 0x00001000")]
    public const int LVS_EX_UNDERLINECOLD = 0x00001000;

    [NativeTypeName("#define LVS_EX_MULTIWORKAREAS 0x00002000")]
    public const int LVS_EX_MULTIWORKAREAS = 0x00002000;

    [NativeTypeName("#define LVS_EX_LABELTIP 0x00004000")]
    public const int LVS_EX_LABELTIP = 0x00004000;

    [NativeTypeName("#define LVS_EX_BORDERSELECT 0x00008000")]
    public const int LVS_EX_BORDERSELECT = 0x00008000;

    [NativeTypeName("#define LVS_EX_DOUBLEBUFFER 0x00010000")]
    public const int LVS_EX_DOUBLEBUFFER = 0x00010000;

    [NativeTypeName("#define LVS_EX_HIDELABELS 0x00020000")]
    public const int LVS_EX_HIDELABELS = 0x00020000;

    [NativeTypeName("#define LVS_EX_SINGLEROW 0x00040000")]
    public const int LVS_EX_SINGLEROW = 0x00040000;

    [NativeTypeName("#define LVS_EX_SNAPTOGRID 0x00080000")]
    public const int LVS_EX_SNAPTOGRID = 0x00080000;

    [NativeTypeName("#define LVS_EX_SIMPLESELECT 0x00100000")]
    public const int LVS_EX_SIMPLESELECT = 0x00100000;

    [NativeTypeName("#define LVS_EX_JUSTIFYCOLUMNS 0x00200000")]
    public const int LVS_EX_JUSTIFYCOLUMNS = 0x00200000;

    [NativeTypeName("#define LVS_EX_TRANSPARENTBKGND 0x00400000")]
    public const int LVS_EX_TRANSPARENTBKGND = 0x00400000;

    [NativeTypeName("#define LVS_EX_TRANSPARENTSHADOWTEXT 0x00800000")]
    public const int LVS_EX_TRANSPARENTSHADOWTEXT = 0x00800000;

    [NativeTypeName("#define LVS_EX_AUTOAUTOARRANGE 0x01000000")]
    public const int LVS_EX_AUTOAUTOARRANGE = 0x01000000;

    [NativeTypeName("#define LVS_EX_HEADERINALLVIEWS 0x02000000")]
    public const int LVS_EX_HEADERINALLVIEWS = 0x02000000;

    [NativeTypeName("#define LVS_EX_AUTOCHECKSELECT 0x08000000")]
    public const int LVS_EX_AUTOCHECKSELECT = 0x08000000;

    [NativeTypeName("#define LVS_EX_AUTOSIZECOLUMNS 0x10000000")]
    public const int LVS_EX_AUTOSIZECOLUMNS = 0x10000000;

    [NativeTypeName("#define LVS_EX_COLUMNSNAPPOINTS 0x40000000")]
    public const int LVS_EX_COLUMNSNAPPOINTS = 0x40000000;

    [NativeTypeName("#define LVS_EX_COLUMNOVERFLOW 0x80000000")]
    public const uint LVS_EX_COLUMNOVERFLOW = 0x80000000;
}
