// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [System.Flags]
    [NativeName("Name", "cl_device_scheduling_controls_capabilities_img")]
    public enum DeviceSchedulingControlsCapabilities : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_LINEAR_ORDER_IMG")]
        SchedulingAlgorithmLinearOrder = 0x1,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_MORTON_ORDER_IMG")]
        SchedulingAlgorithmMortonOrder = 0x2,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_TWOD_MORTON_ORDER_IMG")]
        SchedulingAlgorithmTwodMortonOrder = 0x4,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_THREED_MORTON_ORDER_IMG")]
        SchedulingAlgorithmThreedMortonOrder = 0x8,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_TASK_DEMAND_IMG")]
        ArbitrationAlgorithmTaskDemand = 0x100,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_ROUND_ROBIN_IMG")]
        ArbitrationAlgorithmRoundRobin = 0x200,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_EXECUTE_COUNT_IMG")]
        ExecuteCount = 0x400,
    }
}
