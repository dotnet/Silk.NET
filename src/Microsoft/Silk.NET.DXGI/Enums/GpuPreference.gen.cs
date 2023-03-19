// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_GPU_PREFERENCE")]
    public enum GpuPreference : int
    {
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "DXGI_GPU_PREFERENCE_UNSPECIFIED")]
        GpuPreferenceUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"MinimumPower\"")]
        [NativeName("Name", "DXGI_GPU_PREFERENCE_MINIMUM_POWER")]
        GpuPreferenceMinimumPower = 0x1,
        [Obsolete("Deprecated in favour of \"HighPerformance\"")]
        [NativeName("Name", "DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE")]
        GpuPreferenceHighPerformance = 0x2,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_UNSPECIFIED")]
        Unspecified = 0x0,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_MINIMUM_POWER")]
        MinimumPower = 0x1,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE")]
        HighPerformance = 0x2,
    }
}
