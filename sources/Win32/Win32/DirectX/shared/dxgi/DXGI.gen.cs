// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DXGI
{
    [NativeTypeName("#define DXGI_USAGE_SHADER_INPUT 0x00000010UL")]
    public const uint DXGI_USAGE_SHADER_INPUT = 0x00000010U;

    [NativeTypeName("#define DXGI_USAGE_RENDER_TARGET_OUTPUT 0x00000020UL")]
    public const uint DXGI_USAGE_RENDER_TARGET_OUTPUT = 0x00000020U;

    [NativeTypeName("#define DXGI_USAGE_BACK_BUFFER 0x00000040UL")]
    public const uint DXGI_USAGE_BACK_BUFFER = 0x00000040U;

    [NativeTypeName("#define DXGI_USAGE_SHARED 0x00000080UL")]
    public const uint DXGI_USAGE_SHARED = 0x00000080U;

    [NativeTypeName("#define DXGI_USAGE_READ_ONLY 0x00000100UL")]
    public const uint DXGI_USAGE_READ_ONLY = 0x00000100U;

    [NativeTypeName("#define DXGI_USAGE_DISCARD_ON_PRESENT 0x00000200UL")]
    public const uint DXGI_USAGE_DISCARD_ON_PRESENT = 0x00000200U;

    [NativeTypeName("#define DXGI_USAGE_UNORDERED_ACCESS 0x00000400UL")]
    public const uint DXGI_USAGE_UNORDERED_ACCESS = 0x00000400U;

    [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_MINIMUM ( 0x28000000 )")]
    public const int DXGI_RESOURCE_PRIORITY_MINIMUM = (0x28000000);

    [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_LOW ( 0x50000000 )")]
    public const int DXGI_RESOURCE_PRIORITY_LOW = (0x50000000);

    [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_NORMAL ( 0x78000000 )")]
    public const int DXGI_RESOURCE_PRIORITY_NORMAL = (0x78000000);

    [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_HIGH ( 0xa0000000 )")]
    public const uint DXGI_RESOURCE_PRIORITY_HIGH = (0xa0000000);

    [NativeTypeName("#define DXGI_RESOURCE_PRIORITY_MAXIMUM ( 0xc8000000 )")]
    public const uint DXGI_RESOURCE_PRIORITY_MAXIMUM = (0xc8000000);

    [NativeTypeName("#define DXGI_MAP_READ ( 1UL )")]
    public const uint DXGI_MAP_READ = (1U);

    [NativeTypeName("#define DXGI_MAP_WRITE ( 2UL )")]
    public const uint DXGI_MAP_WRITE = (2U);

    [NativeTypeName("#define DXGI_MAP_DISCARD ( 4UL )")]
    public const uint DXGI_MAP_DISCARD = (4U);

    [NativeTypeName("#define DXGI_ENUM_MODES_INTERLACED ( 1UL )")]
    public const uint DXGI_ENUM_MODES_INTERLACED = (1U);

    [NativeTypeName("#define DXGI_ENUM_MODES_SCALING ( 2UL )")]
    public const uint DXGI_ENUM_MODES_SCALING = (2U);

    [NativeTypeName("#define DXGI_MAX_SWAP_CHAIN_BUFFERS ( 16 )")]
    public const int DXGI_MAX_SWAP_CHAIN_BUFFERS = (16);

    [NativeTypeName("#define DXGI_PRESENT_TEST 0x00000001UL")]
    public const uint DXGI_PRESENT_TEST = 0x00000001U;

    [NativeTypeName("#define DXGI_PRESENT_DO_NOT_SEQUENCE 0x00000002UL")]
    public const uint DXGI_PRESENT_DO_NOT_SEQUENCE = 0x00000002U;

    [NativeTypeName("#define DXGI_PRESENT_RESTART 0x00000004UL")]
    public const uint DXGI_PRESENT_RESTART = 0x00000004U;

    [NativeTypeName("#define DXGI_PRESENT_DO_NOT_WAIT 0x00000008UL")]
    public const uint DXGI_PRESENT_DO_NOT_WAIT = 0x00000008U;

    [NativeTypeName("#define DXGI_PRESENT_STEREO_PREFER_RIGHT 0x00000010UL")]
    public const uint DXGI_PRESENT_STEREO_PREFER_RIGHT = 0x00000010U;

    [NativeTypeName("#define DXGI_PRESENT_STEREO_TEMPORARY_MONO 0x00000020UL")]
    public const uint DXGI_PRESENT_STEREO_TEMPORARY_MONO = 0x00000020U;

    [NativeTypeName("#define DXGI_PRESENT_RESTRICT_TO_OUTPUT 0x00000040UL")]
    public const uint DXGI_PRESENT_RESTRICT_TO_OUTPUT = 0x00000040U;

    [NativeTypeName("#define DXGI_PRESENT_USE_DURATION 0x00000100UL")]
    public const uint DXGI_PRESENT_USE_DURATION = 0x00000100U;

    [NativeTypeName("#define DXGI_PRESENT_ALLOW_TEARING 0x00000200UL")]
    public const uint DXGI_PRESENT_ALLOW_TEARING = 0x00000200U;

    [NativeTypeName("#define DXGI_MWA_NO_WINDOW_CHANGES ( 1 << 0 )")]
    public const int DXGI_MWA_NO_WINDOW_CHANGES = (1 << 0);

    [NativeTypeName("#define DXGI_MWA_NO_ALT_ENTER ( 1 << 1 )")]
    public const int DXGI_MWA_NO_ALT_ENTER = (1 << 1);

    [NativeTypeName("#define DXGI_MWA_NO_PRINT_SCREEN ( 1 << 2 )")]
    public const int DXGI_MWA_NO_PRINT_SCREEN = (1 << 2);

    [NativeTypeName("#define DXGI_MWA_VALID ( 0x7 )")]
    public const int DXGI_MWA_VALID = (0x7);
}
