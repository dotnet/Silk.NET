// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY")]
    public enum CommandQueueGlobalPriority : int
    {
        [Obsolete("Deprecated in favour of \"Idle\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_IDLE")]
        CommandQueueGlobalPriorityIdle = 0x0,
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_DEFAULT")]
        CommandQueueGlobalPriorityDefault = 0x1,
        [Obsolete("Deprecated in favour of \"Normal0\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_NORMAL_0")]
        CommandQueueGlobalPriorityNormal0 = 0x2,
        [Obsolete("Deprecated in favour of \"SoftRealtime0\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_0")]
        CommandQueueGlobalPrioritySoftRealtime0 = 0x12,
        [Obsolete("Deprecated in favour of \"SoftRealtime1\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_1")]
        CommandQueueGlobalPrioritySoftRealtime1 = 0x13,
        [Obsolete("Deprecated in favour of \"SoftRealtime2\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_2")]
        CommandQueueGlobalPrioritySoftRealtime2 = 0x14,
        [Obsolete("Deprecated in favour of \"SoftRealtime3\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_3")]
        CommandQueueGlobalPrioritySoftRealtime3 = 0x15,
        [Obsolete("Deprecated in favour of \"SoftRealtime4\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_4")]
        CommandQueueGlobalPrioritySoftRealtime4 = 0x16,
        [Obsolete("Deprecated in favour of \"SoftRealtime5\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_5")]
        CommandQueueGlobalPrioritySoftRealtime5 = 0x17,
        [Obsolete("Deprecated in favour of \"SoftRealtime6\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_6")]
        CommandQueueGlobalPrioritySoftRealtime6 = 0x18,
        [Obsolete("Deprecated in favour of \"SoftRealtime7\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_7")]
        CommandQueueGlobalPrioritySoftRealtime7 = 0x19,
        [Obsolete("Deprecated in favour of \"SoftRealtime8\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_8")]
        CommandQueueGlobalPrioritySoftRealtime8 = 0x1A,
        [Obsolete("Deprecated in favour of \"SoftRealtime9\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_9")]
        CommandQueueGlobalPrioritySoftRealtime9 = 0x1B,
        [Obsolete("Deprecated in favour of \"SoftRealtime10\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_10")]
        CommandQueueGlobalPrioritySoftRealtime10 = 0x1C,
        [Obsolete("Deprecated in favour of \"SoftRealtime11\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_11")]
        CommandQueueGlobalPrioritySoftRealtime11 = 0x1D,
        [Obsolete("Deprecated in favour of \"SoftRealtime12\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_12")]
        CommandQueueGlobalPrioritySoftRealtime12 = 0x1E,
        [Obsolete("Deprecated in favour of \"SoftRealtime13\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_13")]
        CommandQueueGlobalPrioritySoftRealtime13 = 0x1F,
        [Obsolete("Deprecated in favour of \"HardRealtime\"")]
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_HARD_REALTIME")]
        CommandQueueGlobalPriorityHardRealtime = 0x20,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_IDLE")]
        Idle = 0x0,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_NORMAL_0")]
        Normal0 = 0x2,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_0")]
        SoftRealtime0 = 0x12,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_1")]
        SoftRealtime1 = 0x13,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_2")]
        SoftRealtime2 = 0x14,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_3")]
        SoftRealtime3 = 0x15,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_4")]
        SoftRealtime4 = 0x16,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_5")]
        SoftRealtime5 = 0x17,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_6")]
        SoftRealtime6 = 0x18,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_7")]
        SoftRealtime7 = 0x19,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_8")]
        SoftRealtime8 = 0x1A,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_9")]
        SoftRealtime9 = 0x1B,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_10")]
        SoftRealtime10 = 0x1C,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_11")]
        SoftRealtime11 = 0x1D,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_12")]
        SoftRealtime12 = 0x1E,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_SOFT_REALTIME_13")]
        SoftRealtime13 = 0x1F,
        [NativeName("Name", "D3D12_COMMAND_QUEUE_GLOBAL_PRIORITY_HARD_REALTIME")]
        HardRealtime = 0x20,
    }
}
