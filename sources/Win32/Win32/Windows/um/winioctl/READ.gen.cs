// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class READ
{
    [NativeTypeName("#define READ_COMPRESSION_INFO_VALID 0x00000020")]
    public const int READ_COMPRESSION_INFO_VALID = 0x00000020;

    [NativeTypeName("#define READ_COPY_NUMBER_KEY 0x52434e00")]
    public const int READ_COPY_NUMBER_KEY = 0x52434e00;

    [NativeTypeName("#define READ_COPY_NUMBER_BYPASS_CACHE_FLAG 0x00000100")]
    public const int READ_COPY_NUMBER_BYPASS_CACHE_FLAG = 0x00000100;

    [NativeTypeName("#define READ_ATTRIBUTE_BUFFER_SIZE 512")]
    public const int READ_ATTRIBUTE_BUFFER_SIZE = 512;

    [NativeTypeName("#define READ_THRESHOLD_BUFFER_SIZE 512")]
    public const int READ_THRESHOLD_BUFFER_SIZE = 512;

    [NativeTypeName("#define READ_ATTRIBUTES 0xD0")]
    public const int READ_ATTRIBUTES = 0xD0;

    [NativeTypeName("#define READ_THRESHOLDS 0xD1")]
    public const int READ_THRESHOLDS = 0xD1;
}
