// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HHT
{
    [NativeTypeName("#define HHT_NOWHERE 0x0001")]
    public const int HHT_NOWHERE = 0x0001;

    [NativeTypeName("#define HHT_ONHEADER 0x0002")]
    public const int HHT_ONHEADER = 0x0002;

    [NativeTypeName("#define HHT_ONDIVIDER 0x0004")]
    public const int HHT_ONDIVIDER = 0x0004;

    [NativeTypeName("#define HHT_ONDIVOPEN 0x0008")]
    public const int HHT_ONDIVOPEN = 0x0008;

    [NativeTypeName("#define HHT_ONFILTER 0x0010")]
    public const int HHT_ONFILTER = 0x0010;

    [NativeTypeName("#define HHT_ONFILTERBUTTON 0x0020")]
    public const int HHT_ONFILTERBUTTON = 0x0020;

    [NativeTypeName("#define HHT_ABOVE 0x0100")]
    public const int HHT_ABOVE = 0x0100;

    [NativeTypeName("#define HHT_BELOW 0x0200")]
    public const int HHT_BELOW = 0x0200;

    [NativeTypeName("#define HHT_TORIGHT 0x0400")]
    public const int HHT_TORIGHT = 0x0400;

    [NativeTypeName("#define HHT_TOLEFT 0x0800")]
    public const int HHT_TOLEFT = 0x0800;

    [NativeTypeName("#define HHT_ONITEMSTATEICON 0x1000")]
    public const int HHT_ONITEMSTATEICON = 0x1000;

    [NativeTypeName("#define HHT_ONDROPDOWN 0x2000")]
    public const int HHT_ONDROPDOWN = 0x2000;

    [NativeTypeName("#define HHT_ONOVERFLOW 0x4000")]
    public const int HHT_ONOVERFLOW = 0x4000;
}
