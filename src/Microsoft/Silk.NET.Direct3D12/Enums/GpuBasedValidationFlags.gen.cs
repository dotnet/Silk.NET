// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS")]
    public enum GpuBasedValidationFlags : int
    {
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS_NONE")]
        GpuBasedValidationFlagsNone = 0x0,
        [NativeName("Name", "D3D12_GPU_BASED_VALIDATION_FLAGS_DISABLE_STATE_TRACKING")]
        GpuBasedValidationFlagsDisableStateTracking = 0x1,
    }
}
