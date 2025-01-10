// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DDSCAPS3
{
    [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_MASK 0x0000001FL")]
    public const int DDSCAPS3_MULTISAMPLE_MASK = 0x0000001F;

    [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_QUALITY_MASK 0x000000E0L")]
    public const int DDSCAPS3_MULTISAMPLE_QUALITY_MASK = 0x000000E0;

    [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT 5")]
    public const int DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT = 5;

    [NativeTypeName("#define DDSCAPS3_RESERVED1 0x00000100L")]
    public const int DDSCAPS3_RESERVED1 = 0x00000100;

    [NativeTypeName("#define DDSCAPS3_RESERVED2 0x00000200L")]
    public const int DDSCAPS3_RESERVED2 = 0x00000200;

    [NativeTypeName("#define DDSCAPS3_LIGHTWEIGHTMIPMAP 0x00000400L")]
    public const int DDSCAPS3_LIGHTWEIGHTMIPMAP = 0x00000400;

    [NativeTypeName("#define DDSCAPS3_AUTOGENMIPMAP 0x00000800L")]
    public const int DDSCAPS3_AUTOGENMIPMAP = 0x00000800;

    [NativeTypeName("#define DDSCAPS3_DMAP 0x00001000L")]
    public const int DDSCAPS3_DMAP = 0x00001000;

    [NativeTypeName("#define DDSCAPS3_CREATESHAREDRESOURCE 0x00002000L")]
    public const int DDSCAPS3_CREATESHAREDRESOURCE = 0x00002000;

    [NativeTypeName("#define DDSCAPS3_READONLYRESOURCE 0x00004000L")]
    public const int DDSCAPS3_READONLYRESOURCE = 0x00004000;

    [NativeTypeName("#define DDSCAPS3_OPENSHAREDRESOURCE 0x00008000L")]
    public const int DDSCAPS3_OPENSHAREDRESOURCE = 0x00008000;
}
