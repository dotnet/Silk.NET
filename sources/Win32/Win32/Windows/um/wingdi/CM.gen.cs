// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CM
{
    [NativeTypeName("#define CM_OUT_OF_GAMUT 255")]
    public const int CM_OUT_OF_GAMUT = 255;

    [NativeTypeName("#define CM_IN_GAMUT 0")]
    public const int CM_IN_GAMUT = 0;

    [NativeTypeName("#define CM_NONE 0x00000000")]
    public const int CM_NONE = 0x00000000;

    [NativeTypeName("#define CM_DEVICE_ICM 0x00000001")]
    public const int CM_DEVICE_ICM = 0x00000001;

    [NativeTypeName("#define CM_GAMMA_RAMP 0x00000002")]
    public const int CM_GAMMA_RAMP = 0x00000002;

    [NativeTypeName("#define CM_CMYK_COLOR 0x00000004")]
    public const int CM_CMYK_COLOR = 0x00000004;
}
