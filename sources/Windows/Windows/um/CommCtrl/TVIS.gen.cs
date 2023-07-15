// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TVIS
{
    [NativeTypeName("#define TVIS_SELECTED 0x0002")]
    public const int TVIS_SELECTED = 0x0002;
    [NativeTypeName("#define TVIS_CUT 0x0004")]
    public const int TVIS_CUT = 0x0004;
    [NativeTypeName("#define TVIS_DROPHILITED 0x0008")]
    public const int TVIS_DROPHILITED = 0x0008;
    [NativeTypeName("#define TVIS_BOLD 0x0010")]
    public const int TVIS_BOLD = 0x0010;
    [NativeTypeName("#define TVIS_EXPANDED 0x0020")]
    public const int TVIS_EXPANDED = 0x0020;
    [NativeTypeName("#define TVIS_EXPANDEDONCE 0x0040")]
    public const int TVIS_EXPANDEDONCE = 0x0040;
    [NativeTypeName("#define TVIS_EXPANDPARTIAL 0x0080")]
    public const int TVIS_EXPANDPARTIAL = 0x0080;
    [NativeTypeName("#define TVIS_OVERLAYMASK 0x0F00")]
    public const int TVIS_OVERLAYMASK = 0x0F00;
    [NativeTypeName("#define TVIS_STATEIMAGEMASK 0xF000")]
    public const int TVIS_STATEIMAGEMASK = 0xF000;
    [NativeTypeName("#define TVIS_USERMASK 0xF000")]
    public const int TVIS_USERMASK = 0xF000;
    [NativeTypeName("#define TVIS_EX_FLAT 0x0001")]
    public const int TVIS_EX_FLAT = 0x0001;
    [NativeTypeName("#define TVIS_EX_DISABLED 0x0002")]
    public const int TVIS_EX_DISABLED = 0x0002;
    [NativeTypeName("#define TVIS_EX_ALL 0x0002")]
    public const int TVIS_EX_ALL = 0x0002;
}