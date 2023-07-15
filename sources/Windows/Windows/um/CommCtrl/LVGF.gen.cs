// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class LVGF
{
    [NativeTypeName("#define LVGF_NONE 0x00000000")]
    public const int LVGF_NONE = 0x00000000;
    [NativeTypeName("#define LVGF_HEADER 0x00000001")]
    public const int LVGF_HEADER = 0x00000001;
    [NativeTypeName("#define LVGF_FOOTER 0x00000002")]
    public const int LVGF_FOOTER = 0x00000002;
    [NativeTypeName("#define LVGF_STATE 0x00000004")]
    public const int LVGF_STATE = 0x00000004;
    [NativeTypeName("#define LVGF_ALIGN 0x00000008")]
    public const int LVGF_ALIGN = 0x00000008;
    [NativeTypeName("#define LVGF_GROUPID 0x00000010")]
    public const int LVGF_GROUPID = 0x00000010;
    [NativeTypeName("#define LVGF_SUBTITLE 0x00000100")]
    public const int LVGF_SUBTITLE = 0x00000100;
    [NativeTypeName("#define LVGF_TASK 0x00000200")]
    public const int LVGF_TASK = 0x00000200;
    [NativeTypeName("#define LVGF_DESCRIPTIONTOP 0x00000400")]
    public const int LVGF_DESCRIPTIONTOP = 0x00000400;
    [NativeTypeName("#define LVGF_DESCRIPTIONBOTTOM 0x00000800")]
    public const int LVGF_DESCRIPTIONBOTTOM = 0x00000800;
    [NativeTypeName("#define LVGF_TITLEIMAGE 0x00001000")]
    public const int LVGF_TITLEIMAGE = 0x00001000;
    [NativeTypeName("#define LVGF_EXTENDEDIMAGE 0x00002000")]
    public const int LVGF_EXTENDEDIMAGE = 0x00002000;
    [NativeTypeName("#define LVGF_ITEMS 0x00004000")]
    public const int LVGF_ITEMS = 0x00004000;
    [NativeTypeName("#define LVGF_SUBSET 0x00008000")]
    public const int LVGF_SUBSET = 0x00008000;
    [NativeTypeName("#define LVGF_SUBSETITEMS 0x00010000")]
    public const int LVGF_SUBSETITEMS = 0x00010000;
}