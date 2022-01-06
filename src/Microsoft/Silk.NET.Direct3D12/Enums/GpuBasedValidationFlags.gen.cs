// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS")]
    public enum GpuBasedValidationFlags : int
    {
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS_NONE")]
        GpuBasedValidationFlagsNone = 0x0,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING")]
        GpuBasedValidationFlagsDisableStateTracking = 0x1,
    }
}
