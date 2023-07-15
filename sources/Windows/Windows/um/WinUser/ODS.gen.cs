// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ODS
{
    [NativeTypeName("#define ODS_SELECTED 0x0001")]
    public const int ODS_SELECTED = 0x0001;
    [NativeTypeName("#define ODS_GRAYED 0x0002")]
    public const int ODS_GRAYED = 0x0002;
    [NativeTypeName("#define ODS_DISABLED 0x0004")]
    public const int ODS_DISABLED = 0x0004;
    [NativeTypeName("#define ODS_CHECKED 0x0008")]
    public const int ODS_CHECKED = 0x0008;
    [NativeTypeName("#define ODS_FOCUS 0x0010")]
    public const int ODS_FOCUS = 0x0010;
    [NativeTypeName("#define ODS_DEFAULT 0x0020")]
    public const int ODS_DEFAULT = 0x0020;
    [NativeTypeName("#define ODS_COMBOBOXEDIT 0x1000")]
    public const int ODS_COMBOBOXEDIT = 0x1000;
    [NativeTypeName("#define ODS_HOTLIGHT 0x0040")]
    public const int ODS_HOTLIGHT = 0x0040;
    [NativeTypeName("#define ODS_INACTIVE 0x0080")]
    public const int ODS_INACTIVE = 0x0080;
    [NativeTypeName("#define ODS_NOACCEL 0x0100")]
    public const int ODS_NOACCEL = 0x0100;
    [NativeTypeName("#define ODS_NOFOCUSRECT 0x0200")]
    public const int ODS_NOFOCUSRECT = 0x0200;
}