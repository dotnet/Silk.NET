// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GPT
{
    [NativeTypeName("#define GPT_ATTRIBUTE_PLATFORM_REQUIRED (0x0000000000000001)")]
    public const int GPT_ATTRIBUTE_PLATFORM_REQUIRED = (0x0000000000000001);

    [NativeTypeName("#define GPT_ATTRIBUTE_NO_BLOCK_IO_PROTOCOL (0x0000000000000002)")]
    public const int GPT_ATTRIBUTE_NO_BLOCK_IO_PROTOCOL = (0x0000000000000002);

    [NativeTypeName("#define GPT_ATTRIBUTE_LEGACY_BIOS_BOOTABLE (0x0000000000000004)")]
    public const int GPT_ATTRIBUTE_LEGACY_BIOS_BOOTABLE = (0x0000000000000004);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER (0x8000000000000000)")]
    public const ulong GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER = (0x8000000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_HIDDEN (0x4000000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_HIDDEN = (0x4000000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY (0x2000000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY = (0x2000000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY (0x1000000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY = (0x1000000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_OFFLINE (0x0800000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_OFFLINE = (0x0800000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_DAX (0x0400000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_DAX = (0x0400000000000000);

    [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_SERVICE (0x0200000000000000)")]
    public const long GPT_BASIC_DATA_ATTRIBUTE_SERVICE = (0x0200000000000000);

    [NativeTypeName("#define GPT_SPACES_ATTRIBUTE_NO_METADATA (0x8000000000000000)")]
    public const ulong GPT_SPACES_ATTRIBUTE_NO_METADATA = (0x8000000000000000);
}
