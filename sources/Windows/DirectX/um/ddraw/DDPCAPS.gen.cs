// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDPCAPS
{
    [NativeTypeName("#define DDPCAPS_4BIT 0x00000001l")]
    public const int DDPCAPS_4BIT = 0x00000001;
    [NativeTypeName("#define DDPCAPS_8BITENTRIES 0x00000002l")]
    public const int DDPCAPS_8BITENTRIES = 0x00000002;
    [NativeTypeName("#define DDPCAPS_8BIT 0x00000004l")]
    public const int DDPCAPS_8BIT = 0x00000004;
    [NativeTypeName("#define DDPCAPS_INITIALIZE 0x00000000l")]
    public const int DDPCAPS_INITIALIZE = 0x00000000;
    [NativeTypeName("#define DDPCAPS_PRIMARYSURFACE 0x00000010l")]
    public const int DDPCAPS_PRIMARYSURFACE = 0x00000010;
    [NativeTypeName("#define DDPCAPS_PRIMARYSURFACELEFT 0x00000020l")]
    public const int DDPCAPS_PRIMARYSURFACELEFT = 0x00000020;
    [NativeTypeName("#define DDPCAPS_ALLOW256 0x00000040l")]
    public const int DDPCAPS_ALLOW256 = 0x00000040;
    [NativeTypeName("#define DDPCAPS_VSYNC 0x00000080l")]
    public const int DDPCAPS_VSYNC = 0x00000080;
    [NativeTypeName("#define DDPCAPS_1BIT 0x00000100l")]
    public const int DDPCAPS_1BIT = 0x00000100;
    [NativeTypeName("#define DDPCAPS_2BIT 0x00000200l")]
    public const int DDPCAPS_2BIT = 0x00000200;
    [NativeTypeName("#define DDPCAPS_ALPHA 0x00000400l")]
    public const int DDPCAPS_ALPHA = 0x00000400;
}