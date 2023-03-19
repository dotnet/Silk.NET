// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAGS")]
    public enum CommandQueueFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_NONE")]
        CommandQueueFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"DisableGpuTimeout\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_DISABLE_GPU_TIMEOUT")]
        CommandQueueFlagDisableGpuTimeout = 0x1,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_DISABLE_GPU_TIMEOUT")]
        DisableGpuTimeout = 0x1,
    }
}
