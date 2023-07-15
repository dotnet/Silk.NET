// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CDIS
{
    [NativeTypeName("#define CDIS_SELECTED 0x0001")]
    public const int CDIS_SELECTED = 0x0001;
    [NativeTypeName("#define CDIS_GRAYED 0x0002")]
    public const int CDIS_GRAYED = 0x0002;
    [NativeTypeName("#define CDIS_DISABLED 0x0004")]
    public const int CDIS_DISABLED = 0x0004;
    [NativeTypeName("#define CDIS_CHECKED 0x0008")]
    public const int CDIS_CHECKED = 0x0008;
    [NativeTypeName("#define CDIS_FOCUS 0x0010")]
    public const int CDIS_FOCUS = 0x0010;
    [NativeTypeName("#define CDIS_DEFAULT 0x0020")]
    public const int CDIS_DEFAULT = 0x0020;
    [NativeTypeName("#define CDIS_HOT 0x0040")]
    public const int CDIS_HOT = 0x0040;
    [NativeTypeName("#define CDIS_MARKED 0x0080")]
    public const int CDIS_MARKED = 0x0080;
    [NativeTypeName("#define CDIS_INDETERMINATE 0x0100")]
    public const int CDIS_INDETERMINATE = 0x0100;
    [NativeTypeName("#define CDIS_SHOWKEYBOARDCUES 0x0200")]
    public const int CDIS_SHOWKEYBOARDCUES = 0x0200;
    [NativeTypeName("#define CDIS_NEARHOT 0x0400")]
    public const int CDIS_NEARHOT = 0x0400;
    [NativeTypeName("#define CDIS_OTHERSIDEHOT 0x0800")]
    public const int CDIS_OTHERSIDEHOT = 0x0800;
    [NativeTypeName("#define CDIS_DROPHILITED 0x1000")]
    public const int CDIS_DROPHILITED = 0x1000;
}