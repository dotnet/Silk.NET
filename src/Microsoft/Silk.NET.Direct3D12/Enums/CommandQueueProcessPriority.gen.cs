// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_QUEUE_PROCESS_PRIORITY")]
    public enum CommandQueueProcessPriority : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_NORMAL")]
        CommandQueueProcessPriorityNormal = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_HIGH")]
        CommandQueueProcessPriorityHigh = 0x1,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_PROCESS_PRIORITY_HIGH")]
        High = 0x1,
    }
}
