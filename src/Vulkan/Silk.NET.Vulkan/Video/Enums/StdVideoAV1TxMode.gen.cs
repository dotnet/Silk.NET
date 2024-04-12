// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoAV1TxMode")]
    public enum StdVideoAV1TxMode : int
    {
        [Obsolete("Deprecated in favour of \"Only4X4\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_ONLY_4X4")]
        StdVideoAV1TXModeOnly4X4 = 0x0,
        [Obsolete("Deprecated in favour of \"Largest\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_LARGEST")]
        StdVideoAV1TXModeLargest = 0x1,
        [Obsolete("Deprecated in favour of \"Select\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_SELECT")]
        StdVideoAV1TXModeSelect = 0x2,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_INVALID")]
        StdVideoAV1TXModeInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_MAX_ENUM")]
        StdVideoAV1TXModeMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_ONLY_4X4")]
        Only4X4 = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_LARGEST")]
        Largest = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_SELECT")]
        Select = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_TX_MODE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
