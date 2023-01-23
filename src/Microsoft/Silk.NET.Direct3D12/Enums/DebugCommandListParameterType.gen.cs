// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE")]
    public enum DebugCommandListParameterType : int
    {
        [Obsolete("Deprecated in favour of \"GpuBasedValidationSettings\"")]
        [NativeName("Name", "D3D12_DEBUG_COMMAND_LIST_PARAMETER_GPU_BASED_VALIDATION_SETTINGS")]
        DebugCommandListParameterGpuBasedValidationSettings = 0x0,
        [NativeName("Name", "D3D12_DEBUG_COMMAND_LIST_PARAMETER_GPU_BASED_VALIDATION_SETTINGS")]
        GpuBasedValidationSettings = 0x0,
    }
}
