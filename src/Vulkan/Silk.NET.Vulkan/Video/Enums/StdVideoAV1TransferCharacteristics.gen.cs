// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1TransferCharacteristics")]
    public enum StdVideoAV1TransferCharacteristics : int
    {
        [Obsolete("Deprecated in favour of \"Reserved0\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0")]
        StdVideoAV1TransferCharacteristicsReserved0 = 0x0,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709")]
        StdVideoAV1TransferCharacteristicsBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
        StdVideoAV1TransferCharacteristicsUnspecified = 0x2,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3")]
        StdVideoAV1TransferCharacteristicsReserved3 = 0x3,
        [Obsolete("Deprecated in favour of \"BT470M\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M")]
        StdVideoAV1TransferCharacteristicsBT470M = 0x4,
        [Obsolete("Deprecated in favour of \"BT470BG\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G")]
        StdVideoAV1TransferCharacteristicsBT470BG = 0x5,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601")]
        StdVideoAV1TransferCharacteristicsBT601 = 0x6,
        [Obsolete("Deprecated in favour of \"Smpte240\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240")]
        StdVideoAV1TransferCharacteristicsSmpte240 = 0x7,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR")]
        StdVideoAV1TransferCharacteristicsLinear = 0x8,
        [Obsolete("Deprecated in favour of \"Log100\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100")]
        StdVideoAV1TransferCharacteristicsLog100 = 0x9,
        [Obsolete("Deprecated in favour of \"Log100Sqrt10\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10")]
        StdVideoAV1TransferCharacteristicsLog100Sqrt10 = 0xA,
        [Obsolete("Deprecated in favour of \"Iec61966\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966")]
        StdVideoAV1TransferCharacteristicsIec61966 = 0xB,
        [Obsolete("Deprecated in favour of \"BT1361\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361")]
        StdVideoAV1TransferCharacteristicsBT1361 = 0xC,
        [Obsolete("Deprecated in favour of \"Srgb\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB")]
        StdVideoAV1TransferCharacteristicsSrgb = 0xD,
        [Obsolete("Deprecated in favour of \"BT202010Bit\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT")]
        StdVideoAV1TransferCharacteristicsBT202010Bit = 0xE,
        [Obsolete("Deprecated in favour of \"BT202012Bit\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT")]
        StdVideoAV1TransferCharacteristicsBT202012Bit = 0xF,
        [Obsolete("Deprecated in favour of \"Smpte2084\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084")]
        StdVideoAV1TransferCharacteristicsSmpte2084 = 0x10,
        [Obsolete("Deprecated in favour of \"Smpte428\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428")]
        StdVideoAV1TransferCharacteristicsSmpte428 = 0x11,
        [Obsolete("Deprecated in favour of \"Hlg\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG")]
        StdVideoAV1TransferCharacteristicsHlg = 0x12,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_INVALID")]
        StdVideoAV1TransferCharacteristicsInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_MAX_ENUM")]
        StdVideoAV1TransferCharacteristicsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_0")]
        Reserved0 = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_709")]
        BT709 = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_UNSPECIFIED")]
        Unspecified = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_RESERVED_3")]
        Reserved3 = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_M")]
        BT470M = 0x4,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_470_B_G")]
        BT470BG = 0x5,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_601")]
        BT601 = 0x6,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_240")]
        Smpte240 = 0x7,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LINEAR")]
        Linear = 0x8,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100")]
        Log100 = 0x9,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_LOG_100_SQRT10")]
        Log100Sqrt10 = 0xA,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_IEC_61966")]
        Iec61966 = 0xB,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_1361")]
        BT1361 = 0xC,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SRGB")]
        Srgb = 0xD,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_10_BIT")]
        BT202010Bit = 0xE,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_BT_2020_12_BIT")]
        BT202012Bit = 0xF,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_2084")]
        Smpte2084 = 0x10,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_SMPTE_428")]
        Smpte428 = 0x11,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_HLG")]
        Hlg = 0x12,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_TRANSFER_CHARACTERISTICS_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
