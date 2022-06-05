// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY")]
    public enum CommandQueuePriority : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_NORMAL")]
        CommandQueuePriorityNormal = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_HIGH")]
        CommandQueuePriorityHigh = 0x64,
        [Obsolete("Deprecated in favour of \"GlobalRealtime\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME")]
        CommandQueuePriorityGlobalRealtime = 0x2710,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_HIGH")]
        High = 0x64,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME")]
        GlobalRealtime = 0x2710,
    }
}
