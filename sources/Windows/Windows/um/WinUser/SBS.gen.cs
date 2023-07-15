// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SBS
{
    [NativeTypeName("#define SBS_HORZ 0x0000L")]
    public const int SBS_HORZ = 0x0000;
    [NativeTypeName("#define SBS_VERT 0x0001L")]
    public const int SBS_VERT = 0x0001;
    [NativeTypeName("#define SBS_TOPALIGN 0x0002L")]
    public const int SBS_TOPALIGN = 0x0002;
    [NativeTypeName("#define SBS_LEFTALIGN 0x0002L")]
    public const int SBS_LEFTALIGN = 0x0002;
    [NativeTypeName("#define SBS_BOTTOMALIGN 0x0004L")]
    public const int SBS_BOTTOMALIGN = 0x0004;
    [NativeTypeName("#define SBS_RIGHTALIGN 0x0004L")]
    public const int SBS_RIGHTALIGN = 0x0004;
    [NativeTypeName("#define SBS_SIZEBOXTOPLEFTALIGN 0x0002L")]
    public const int SBS_SIZEBOXTOPLEFTALIGN = 0x0002;
    [NativeTypeName("#define SBS_SIZEBOXBOTTOMRIGHTALIGN 0x0004L")]
    public const int SBS_SIZEBOXBOTTOMRIGHTALIGN = 0x0004;
    [NativeTypeName("#define SBS_SIZEBOX 0x0008L")]
    public const int SBS_SIZEBOX = 0x0008;
    [NativeTypeName("#define SBS_SIZEGRIP 0x0010L")]
    public const int SBS_SIZEGRIP = 0x0010;
}