// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapobase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class XAPOBASE
{
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_TAG WAVE_FORMAT_IEEE_FLOAT")]
    public const int XAPOBASE_DEFAULT_FORMAT_TAG = 0x0003;

    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MIN_CHANNELS XAPO_MIN_CHANNELS")]
    public const int XAPOBASE_DEFAULT_FORMAT_MIN_CHANNELS = 1;

    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MAX_CHANNELS XAPO_MAX_CHANNELS")]
    public const int XAPOBASE_DEFAULT_FORMAT_MAX_CHANNELS = 64;

    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MIN_FRAMERATE XAPO_MIN_FRAMERATE")]
    public const int XAPOBASE_DEFAULT_FORMAT_MIN_FRAMERATE = 1000;

    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MAX_FRAMERATE XAPO_MAX_FRAMERATE")]
    public const int XAPOBASE_DEFAULT_FORMAT_MAX_FRAMERATE = 200000;

    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_BITSPERSAMPLE 32")]
    public const int XAPOBASE_DEFAULT_FORMAT_BITSPERSAMPLE = 32;

    [NativeTypeName(
        "#define XAPOBASE_DEFAULT_FLAG (XAPO_FLAG_CHANNELS_MUST_MATCH | XAPO_FLAG_FRAMERATE_MUST_MATCH | XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH | XAPO_FLAG_BUFFERCOUNT_MUST_MATCH | XAPO_FLAG_INPLACE_SUPPORTED)"
    )]
    public const int XAPOBASE_DEFAULT_FLAG = (
        0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010
    );

    [NativeTypeName("#define XAPOBASE_DEFAULT_BUFFER_COUNT 1")]
    public const int XAPOBASE_DEFAULT_BUFFER_COUNT = 1;
}
