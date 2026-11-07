// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TransferCharacteristics")]
public enum StdVideoAv1TransferCharacteristics : uint
{
    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0")]
    Reserved0 = 0,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3")]
    Reserved3 = 3,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M")]
    Bt470M = 4,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR")]
    Linear = 8,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100")]
    Log100 = 9,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10")]
    Log100Sqrt10 = 10,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966")]
    Iec61966 = 11,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361")]
    Bt1361 = 12,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB")]
    Srgb = 13,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT")]
    Bt2020x10Bit = 14,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT")]
    Bt2020x12Bit = 15,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084")]
    Smpte2084 = 16,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428")]
    Smpte428 = 17,

    [NativeName("STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG")]
    Hlg = 18,
}
