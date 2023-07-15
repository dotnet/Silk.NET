// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SB
{
    [NativeTypeName("#define SB_NONE 0x00000000")]
    public const int SB_NONE = 0x00000000;
    [NativeTypeName("#define SB_CONST_ALPHA 0x00000001")]
    public const int SB_CONST_ALPHA = 0x00000001;
    [NativeTypeName("#define SB_PIXEL_ALPHA 0x00000002")]
    public const int SB_PIXEL_ALPHA = 0x00000002;
    [NativeTypeName("#define SB_PREMULT_ALPHA 0x00000004")]
    public const int SB_PREMULT_ALPHA = 0x00000004;
    [NativeTypeName("#define SB_GRAD_RECT 0x00000010")]
    public const int SB_GRAD_RECT = 0x00000010;
    [NativeTypeName("#define SB_GRAD_TRI 0x00000020")]
    public const int SB_GRAD_TRI = 0x00000020;
}