// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAGS")]
    public enum CommandQueueFlags : int
    {
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_NONE")]
        CommandQueueFlagNone = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_FLAG_DISABLE_GPU_TIMEOUT")]
        CommandQueueFlagDisableGpuTimeout = 0x1,
    }
}
