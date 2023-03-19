// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_DEVICE_USAGE")]
    public enum HDDeviceUsage : int
    {
        [Obsolete("Deprecated in favour of \"PlaybackNormal\"")]
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_PLAYBACK_NORMAL")]
        HDDeviceUsagePlaybackNormal = 0x0,
        [Obsolete("Deprecated in favour of \"OptimalSpeed\"")]
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_SPEED")]
        HDDeviceUsageOptimalSpeed = 0x1,
        [Obsolete("Deprecated in favour of \"OptimalQuality\"")]
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_QUALITY")]
        HDDeviceUsageOptimalQuality = 0x2,
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_PLAYBACK_NORMAL")]
        PlaybackNormal = 0x0,
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_SPEED")]
        OptimalSpeed = 0x1,
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_QUALITY")]
        OptimalQuality = 0x2,
    }
}
