// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDCOLOR
{
    [NativeTypeName("#define DDCOLOR_BRIGHTNESS 0x00000001l")]
    public const int DDCOLOR_BRIGHTNESS = 0x00000001;
    [NativeTypeName("#define DDCOLOR_CONTRAST 0x00000002l")]
    public const int DDCOLOR_CONTRAST = 0x00000002;
    [NativeTypeName("#define DDCOLOR_HUE 0x00000004l")]
    public const int DDCOLOR_HUE = 0x00000004;
    [NativeTypeName("#define DDCOLOR_SATURATION 0x00000008l")]
    public const int DDCOLOR_SATURATION = 0x00000008;
    [NativeTypeName("#define DDCOLOR_SHARPNESS 0x00000010l")]
    public const int DDCOLOR_SHARPNESS = 0x00000010;
    [NativeTypeName("#define DDCOLOR_GAMMA 0x00000020l")]
    public const int DDCOLOR_GAMMA = 0x00000020;
    [NativeTypeName("#define DDCOLOR_COLORENABLE 0x00000040l")]
    public const int DDCOLOR_COLORENABLE = 0x00000040;
}