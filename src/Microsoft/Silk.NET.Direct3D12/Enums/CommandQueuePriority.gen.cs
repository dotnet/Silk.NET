// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY")]
    public enum CommandQueuePriority : int
    {
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_NORMAL")]
        CommandQueuePriorityNormal = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_HIGH")]
        CommandQueuePriorityHigh = 0x64,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PRIORITY_GLOBAL_REALTIME")]
        CommandQueuePriorityGlobalRealtime = 0x2710,
    }
}
