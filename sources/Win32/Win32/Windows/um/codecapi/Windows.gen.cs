// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.eAVEncH264VProfile;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define STATIC_CODECAPI_AVEncProgressiveUpdateTime 0x649faf66")]
    public const int STATIC_CODECAPI_AVEncProgressiveUpdateTime = 0x649faf66;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncChromaUpdateTime 0x4b4fd998")]
    public const int STATIC_CODECAPI_AVEncChromaUpdateTime = 0x4b4fd998;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncAACEnableVBR 0xe836bb98")]
    public const uint STATIC_CODECAPI_AVEncAACEnableVBR = 0xe836bb98;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncVideoConsecutiveFramesForLayer 0x0AF35522")]
    public const int STATIC_CODECAPI_AVEncVideoConsecutiveFramesForLayer = 0x0AF35522;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncVideoMaxNumRefFrameForLayer 0x3141C639")]
    public const int STATIC_CODECAPI_AVEncVideoMaxNumRefFrameForLayer = 0x3141C639;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncTileRows 0xFBC650FC")]
    public const uint STATIC_CODECAPI_AVEncTileRows = 0xFBC650FC;

    [NativeTypeName("#define STATIC_CODECAPI_AVEncTileColumns 0xB4B31205")]
    public const uint STATIC_CODECAPI_AVEncTileColumns = 0xB4B31205;

    [NativeTypeName("#define STATIC_CODECAPI_FeatureMapFlagsUsed 0x8bfda3b8")]
    public const uint STATIC_CODECAPI_FeatureMapFlagsUsed = 0x8bfda3b8;

    [NativeTypeName(
        "#define eAVEncH264VProfile_ConstrainedHigh eAVEncH264VProfile_UCConstrainedHigh"
    )]
    public const eAVEncH264VProfile eAVEncH264VProfile_ConstrainedHigh =
        eAVEncH264VProfile_UCConstrainedHigh;

    [NativeTypeName("#define AVENC_H263V_LEVELCOUNT 8")]
    public const int AVENC_H263V_LEVELCOUNT = 8;

    [NativeTypeName("#define AVENC_H264V_LEVELCOUNT 16")]
    public const int AVENC_H264V_LEVELCOUNT = 16;

    [NativeTypeName("#define AVENC_H264V_MAX_MBBITS 3200")]
    public const int AVENC_H264V_MAX_MBBITS = 3200;
}
