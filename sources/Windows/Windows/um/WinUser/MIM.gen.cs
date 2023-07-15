// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MIM
{
    [NativeTypeName("#define MIM_MAXHEIGHT 0x00000001")]
    public const int MIM_MAXHEIGHT = 0x00000001;
    [NativeTypeName("#define MIM_BACKGROUND 0x00000002")]
    public const int MIM_BACKGROUND = 0x00000002;
    [NativeTypeName("#define MIM_HELPID 0x00000004")]
    public const int MIM_HELPID = 0x00000004;
    [NativeTypeName("#define MIM_MENUDATA 0x00000008")]
    public const int MIM_MENUDATA = 0x00000008;
    [NativeTypeName("#define MIM_STYLE 0x00000010")]
    public const int MIM_STYLE = 0x00000010;
    [NativeTypeName("#define MIM_APPLYTOSUBMENUS 0x80000000")]
    public const uint MIM_APPLYTOSUBMENUS = 0x80000000;
}