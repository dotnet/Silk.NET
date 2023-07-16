// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class LVNI
{
    [NativeTypeName("#define LVNI_ALL 0x0000")]
    public const int LVNI_ALL = 0x0000;
    [NativeTypeName("#define LVNI_FOCUSED 0x0001")]
    public const int LVNI_FOCUSED = 0x0001;
    [NativeTypeName("#define LVNI_SELECTED 0x0002")]
    public const int LVNI_SELECTED = 0x0002;
    [NativeTypeName("#define LVNI_CUT 0x0004")]
    public const int LVNI_CUT = 0x0004;
    [NativeTypeName("#define LVNI_DROPHILITED 0x0008")]
    public const int LVNI_DROPHILITED = 0x0008;
    [NativeTypeName("#define LVNI_STATEMASK (LVNI_FOCUSED | LVNI_SELECTED | LVNI_CUT | LVNI_DROPHILITED)")]
    public const int LVNI_STATEMASK = (0x0001 | 0x0002 | 0x0004 | 0x0008);
    [NativeTypeName("#define LVNI_VISIBLEORDER 0x0010")]
    public const int LVNI_VISIBLEORDER = 0x0010;
    [NativeTypeName("#define LVNI_PREVIOUS 0x0020")]
    public const int LVNI_PREVIOUS = 0x0020;
    [NativeTypeName("#define LVNI_VISIBLEONLY 0x0040")]
    public const int LVNI_VISIBLEONLY = 0x0040;
    [NativeTypeName("#define LVNI_SAMEGROUPONLY 0x0080")]
    public const int LVNI_SAMEGROUPONLY = 0x0080;
    [NativeTypeName("#define LVNI_ABOVE 0x0100")]
    public const int LVNI_ABOVE = 0x0100;
    [NativeTypeName("#define LVNI_BELOW 0x0200")]
    public const int LVNI_BELOW = 0x0200;
    [NativeTypeName("#define LVNI_TOLEFT 0x0400")]
    public const int LVNI_TOLEFT = 0x0400;
    [NativeTypeName("#define LVNI_TORIGHT 0x0800")]
    public const int LVNI_TORIGHT = 0x0800;
    [NativeTypeName("#define LVNI_DIRECTIONMASK (LVNI_ABOVE | LVNI_BELOW | LVNI_TOLEFT | LVNI_TORIGHT)")]
    public const int LVNI_DIRECTIONMASK = (0x0100 | 0x0200 | 0x0400 | 0x0800);
}