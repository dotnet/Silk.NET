// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TransferCharacteristics")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1TransferCharacteristics : uint
{
    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsReserved0 = 0,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt709 = 1,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsUnspecified = 2,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsReserved3 = 3,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt470M = 4,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt470BG = 5,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt601 = 6,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsSmpte240 = 7,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsLinear = 8,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsLog100 = 9,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsLog100Sqrt10 = 10,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsIec61966 = 11,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt1361 = 12,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsSrgb = 13,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt2020x10Bit = 14,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsBt2020x12Bit = 15,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsSmpte2084 = 16,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsSmpte428 = 17,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsHlg = 18,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TransferCharacteristicsMaxEnum = 0x7FFFFFFF,
}
