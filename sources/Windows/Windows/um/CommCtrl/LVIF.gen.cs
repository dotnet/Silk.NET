// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class LVIF
{
    [NativeTypeName("#define LVIF_TEXT 0x00000001")]
    public const int LVIF_TEXT = 0x00000001;
    [NativeTypeName("#define LVIF_IMAGE 0x00000002")]
    public const int LVIF_IMAGE = 0x00000002;
    [NativeTypeName("#define LVIF_PARAM 0x00000004")]
    public const int LVIF_PARAM = 0x00000004;
    [NativeTypeName("#define LVIF_STATE 0x00000008")]
    public const int LVIF_STATE = 0x00000008;
    [NativeTypeName("#define LVIF_INDENT 0x00000010")]
    public const int LVIF_INDENT = 0x00000010;
    [NativeTypeName("#define LVIF_NORECOMPUTE 0x00000800")]
    public const int LVIF_NORECOMPUTE = 0x00000800;
    [NativeTypeName("#define LVIF_GROUPID 0x00000100")]
    public const int LVIF_GROUPID = 0x00000100;
    [NativeTypeName("#define LVIF_COLUMNS 0x00000200")]
    public const int LVIF_COLUMNS = 0x00000200;
    [NativeTypeName("#define LVIF_COLFMT 0x00010000")]
    public const int LVIF_COLFMT = 0x00010000;
    [NativeTypeName("#define LVIF_DI_SETITEM 0x1000")]
    public const int LVIF_DI_SETITEM = 0x1000;
}