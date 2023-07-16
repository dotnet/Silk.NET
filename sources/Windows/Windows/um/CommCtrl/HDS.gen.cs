// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class HDS
{
    [NativeTypeName("#define HDS_HORZ 0x0000")]
    public const int HDS_HORZ = 0x0000;
    [NativeTypeName("#define HDS_BUTTONS 0x0002")]
    public const int HDS_BUTTONS = 0x0002;
    [NativeTypeName("#define HDS_HOTTRACK 0x0004")]
    public const int HDS_HOTTRACK = 0x0004;
    [NativeTypeName("#define HDS_HIDDEN 0x0008")]
    public const int HDS_HIDDEN = 0x0008;
    [NativeTypeName("#define HDS_DRAGDROP 0x0040")]
    public const int HDS_DRAGDROP = 0x0040;
    [NativeTypeName("#define HDS_FULLDRAG 0x0080")]
    public const int HDS_FULLDRAG = 0x0080;
    [NativeTypeName("#define HDS_FILTERBAR 0x0100")]
    public const int HDS_FILTERBAR = 0x0100;
    [NativeTypeName("#define HDS_FLAT 0x0200")]
    public const int HDS_FLAT = 0x0200;
    [NativeTypeName("#define HDS_CHECKBOXES 0x0400")]
    public const int HDS_CHECKBOXES = 0x0400;
    [NativeTypeName("#define HDS_NOSIZING 0x0800")]
    public const int HDS_NOSIZING = 0x0800;
    [NativeTypeName("#define HDS_OVERFLOW 0x1000")]
    public const int HDS_OVERFLOW = 0x1000;
}