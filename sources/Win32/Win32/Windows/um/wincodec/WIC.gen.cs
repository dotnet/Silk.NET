// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WIC
{
    [NativeTypeName("#define WIC_JPEG_MAX_COMPONENT_COUNT ( 4 )")]
    public const int WIC_JPEG_MAX_COMPONENT_COUNT = (4);

    [NativeTypeName("#define WIC_JPEG_MAX_TABLE_INDEX ( 3 )")]
    public const int WIC_JPEG_MAX_TABLE_INDEX = (3);

    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_ONE ( 0x11 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_ONE = (0x11);

    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_420 ( 0x111122 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_420 = (0x111122);

    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_422 ( 0x111121 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_422 = (0x111121);

    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_440 ( 0x111112 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_440 = (0x111112);

    [NativeTypeName("#define WIC_JPEG_SAMPLE_FACTORS_THREE_444 ( 0x111111 )")]
    public const int WIC_JPEG_SAMPLE_FACTORS_THREE_444 = (0x111111);

    [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_ONE ( 0 )")]
    public const int WIC_JPEG_QUANTIZATION_BASELINE_ONE = (0);

    [NativeTypeName("#define WIC_JPEG_QUANTIZATION_BASELINE_THREE ( 0x10100 )")]
    public const int WIC_JPEG_QUANTIZATION_BASELINE_THREE = (0x10100);

    [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_ONE ( 0 )")]
    public const int WIC_JPEG_HUFFMAN_BASELINE_ONE = (0);

    [NativeTypeName("#define WIC_JPEG_HUFFMAN_BASELINE_THREE ( 0x111100 )")]
    public const int WIC_JPEG_HUFFMAN_BASELINE_THREE = (0x111100);
}
