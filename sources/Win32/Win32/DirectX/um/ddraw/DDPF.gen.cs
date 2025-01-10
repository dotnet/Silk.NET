// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDPF
{
    [NativeTypeName("#define DDPF_ALPHAPIXELS 0x00000001l")]
    public const int DDPF_ALPHAPIXELS = 0x00000001;

    [NativeTypeName("#define DDPF_ALPHA 0x00000002l")]
    public const int DDPF_ALPHA = 0x00000002;

    [NativeTypeName("#define DDPF_FOURCC 0x00000004l")]
    public const int DDPF_FOURCC = 0x00000004;

    [NativeTypeName("#define DDPF_PALETTEINDEXED4 0x00000008l")]
    public const int DDPF_PALETTEINDEXED4 = 0x00000008;

    [NativeTypeName("#define DDPF_PALETTEINDEXEDTO8 0x00000010l")]
    public const int DDPF_PALETTEINDEXEDTO8 = 0x00000010;

    [NativeTypeName("#define DDPF_PALETTEINDEXED8 0x00000020l")]
    public const int DDPF_PALETTEINDEXED8 = 0x00000020;

    [NativeTypeName("#define DDPF_RGB 0x00000040l")]
    public const int DDPF_RGB = 0x00000040;

    [NativeTypeName("#define DDPF_COMPRESSED 0x00000080l")]
    public const int DDPF_COMPRESSED = 0x00000080;

    [NativeTypeName("#define DDPF_RGBTOYUV 0x00000100l")]
    public const int DDPF_RGBTOYUV = 0x00000100;

    [NativeTypeName("#define DDPF_YUV 0x00000200l")]
    public const int DDPF_YUV = 0x00000200;

    [NativeTypeName("#define DDPF_ZBUFFER 0x00000400l")]
    public const int DDPF_ZBUFFER = 0x00000400;

    [NativeTypeName("#define DDPF_PALETTEINDEXED1 0x00000800l")]
    public const int DDPF_PALETTEINDEXED1 = 0x00000800;

    [NativeTypeName("#define DDPF_PALETTEINDEXED2 0x00001000l")]
    public const int DDPF_PALETTEINDEXED2 = 0x00001000;

    [NativeTypeName("#define DDPF_ZPIXELS 0x00002000l")]
    public const int DDPF_ZPIXELS = 0x00002000;

    [NativeTypeName("#define DDPF_STENCILBUFFER 0x00004000l")]
    public const int DDPF_STENCILBUFFER = 0x00004000;

    [NativeTypeName("#define DDPF_ALPHAPREMULT 0x00008000l")]
    public const int DDPF_ALPHAPREMULT = 0x00008000;

    [NativeTypeName("#define DDPF_LUMINANCE 0x00020000l")]
    public const int DDPF_LUMINANCE = 0x00020000;

    [NativeTypeName("#define DDPF_BUMPLUMINANCE 0x00040000l")]
    public const int DDPF_BUMPLUMINANCE = 0x00040000;

    [NativeTypeName("#define DDPF_BUMPDUDV 0x00080000l")]
    public const int DDPF_BUMPDUDV = 0x00080000;
}
