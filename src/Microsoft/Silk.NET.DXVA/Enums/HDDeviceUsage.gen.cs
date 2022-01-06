// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_DEVICE_USAGE")]
    public enum HDDeviceUsage : int
    {
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_PLAYBACK_NORMAL")]
        HDDeviceUsagePlaybackNormal = 0x0,
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_SPEED")]
        HDDeviceUsageOptimalSpeed = 0x1,
        [NativeName("Name", "DXVAHD_DEVICE_USAGE_OPTIMAL_QUALITY")]
        HDDeviceUsageOptimalQuality = 0x2,
    }
}
