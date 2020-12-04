// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE")]
    public enum BackgroundProcessingMode
    {
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED")]
        BackgroundProcessingModeAllowed = 0x0,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS")]
        BackgroundProcessingModeAllowIntrusiveMeasurements = 0x1,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK")]
        BackgroundProcessingModeDisableBackgroundWork = 0x2,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_PROFILING_BY_SYSTEM")]
        BackgroundProcessingModeDisableProfilingBySystem = 0x3,
    }
}
