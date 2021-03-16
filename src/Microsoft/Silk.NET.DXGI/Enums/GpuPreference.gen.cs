// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_GPU_PREFERENCE")]
    public enum GpuPreference : int
    {
        [NativeName("Name", "DXGI_GPU_PREFERENCE_UNSPECIFIED")]
        GpuPreferenceUnspecified = 0x0,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_MINIMUM_POWER")]
        GpuPreferenceMinimumPower = 0x1,
        [NativeName("Name", "DXGI_GPU_PREFERENCE_HIGH_PERFORMANCE")]
        GpuPreferenceHighPerformance = 0x2,
    }
}
