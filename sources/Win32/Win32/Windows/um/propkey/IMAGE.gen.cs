// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propkey.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IMAGE
{
    [NativeTypeName("#define IMAGE_COLORSPACE_SRGB 1u")]
    public const uint IMAGE_COLORSPACE_SRGB = 1U;

    [NativeTypeName("#define IMAGE_COLORSPACE_UNCALIBRATED 0xFFFFu")]
    public const uint IMAGE_COLORSPACE_UNCALIBRATED = 0xFFFFU;

    [NativeTypeName("#define IMAGE_COMPRESSION_UNCOMPRESSED 1u")]
    public const uint IMAGE_COMPRESSION_UNCOMPRESSED = 1U;

    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T3 2u")]
    public const uint IMAGE_COMPRESSION_CCITT_T3 = 2U;

    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T4 3u")]
    public const uint IMAGE_COMPRESSION_CCITT_T4 = 3U;

    [NativeTypeName("#define IMAGE_COMPRESSION_CCITT_T6 4u")]
    public const uint IMAGE_COMPRESSION_CCITT_T6 = 4U;

    [NativeTypeName("#define IMAGE_COMPRESSION_LZW 5u")]
    public const uint IMAGE_COMPRESSION_LZW = 5U;

    [NativeTypeName("#define IMAGE_COMPRESSION_JPEG 6u")]
    public const uint IMAGE_COMPRESSION_JPEG = 6U;

    [NativeTypeName("#define IMAGE_COMPRESSION_PACKBITS 32773u")]
    public const uint IMAGE_COMPRESSION_PACKBITS = 32773U;
}
