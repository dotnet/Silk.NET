// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE")]
    public enum BackgroundProcessingMode : int
    {
        [Obsolete("Deprecated in favour of \"Allowed\"")]
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED")]
        BackgroundProcessingModeAllowed = 0x0,
        [Obsolete("Deprecated in favour of \"AllowIntrusiveMeasurements\"")]
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS")]
        BackgroundProcessingModeAllowIntrusiveMeasurements = 0x1,
        [Obsolete("Deprecated in favour of \"DisableBackgroundWork\"")]
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK")]
        BackgroundProcessingModeDisableBackgroundWork = 0x2,
        [Obsolete("Deprecated in favour of \"DisableProfilingBySystem\"")]
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_PROFILING_BY_SYSTEM")]
        BackgroundProcessingModeDisableProfilingBySystem = 0x3,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOWED")]
        Allowed = 0x0,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_ALLOW_INTRUSIVE_MEASUREMENTS")]
        AllowIntrusiveMeasurements = 0x1,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_BACKGROUND_WORK")]
        DisableBackgroundWork = 0x2,
        [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE_DISABLE_PROFILING_BY_SYSTEM")]
        DisableProfilingBySystem = 0x3,
    }
}
