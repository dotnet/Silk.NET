// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_BACKGROUND_PROCESSING_MODE")]
    public enum BackgroundProcessingMode : int
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
