// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.AMD
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [NativeName("Name", "CLenum")]
    public enum AMD : int
    {
        [NativeName("Name", "CL_DEVICE_PROFILING_TIMER_OFFSET_AMD")]
        DeviceProfilingTimerOffsetAmd = 0x4036,
        [NativeName("Name", "CL_DEVICE_TOPOLOGY_AMD")]
        DeviceTopologyAmd = 0x4037,
        [NativeName("Name", "CL_DEVICE_BOARD_NAME_AMD")]
        DeviceBoardNameAmd = 0x4038,
        [NativeName("Name", "CL_DEVICE_GLOBAL_FREE_MEMORY_AMD")]
        DeviceGlobalFreeMemoryAmd = 0x4039,
        [NativeName("Name", "CL_DEVICE_SIMD_PER_COMPUTE_UNIT_AMD")]
        DeviceSimdPerComputeUnitAmd = 0x4040,
        [NativeName("Name", "CL_DEVICE_SIMD_WIDTH_AMD")]
        DeviceSimdWidthAmd = 0x4041,
        [NativeName("Name", "CL_DEVICE_SIMD_INSTRUCTION_WIDTH_AMD")]
        DeviceSimdInstructionWidthAmd = 0x4042,
        [NativeName("Name", "CL_DEVICE_WAVEFRONT_WIDTH_AMD")]
        DeviceWavefrontWidthAmd = 0x4043,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNELS_AMD")]
        DeviceGlobalMemChannelsAmd = 0x4044,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANKS_AMD")]
        DeviceGlobalMemChannelBanksAmd = 0x4045,
        [NativeName("Name", "CL_DEVICE_GLOBAL_MEM_CHANNEL_BANK_WIDTH_AMD")]
        DeviceGlobalMemChannelBankWidthAmd = 0x4046,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_SIZE_PER_COMPUTE_UNIT_AMD")]
        DeviceLocalMemSizePerComputeUnitAmd = 0x4047,
        [NativeName("Name", "CL_DEVICE_LOCAL_MEM_BANKS_AMD")]
        DeviceLocalMemBanksAmd = 0x4048,
        [NativeName("Name", "CL_DEVICE_THREAD_TRACE_SUPPORTED_AMD")]
        DeviceThreadTraceSupportedAmd = 0x4049,
        [NativeName("Name", "CL_DEVICE_GFXIP_MAJOR_AMD")]
        DeviceGfxipMajorAmd = 0x404A,
        [NativeName("Name", "CL_DEVICE_GFXIP_MINOR_AMD")]
        DeviceGfxipMinorAmd = 0x404B,
        [NativeName("Name", "CL_DEVICE_AVAILABLE_ASYNC_QUEUES_AMD")]
        DeviceAvailableAsyncQueuesAmd = 0x404C,
        [NativeName("Name", "CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_AMD")]
        DevicePreferredWorkGroupSizeAmd = 0x4030,
        [NativeName("Name", "CL_DEVICE_MAX_WORK_GROUP_SIZE_AMD")]
        DeviceMaxWorkGroupSizeAmd = 0x4031,
        [NativeName("Name", "CL_DEVICE_PREFERRED_CONSTANT_BUFFER_SIZE_AMD")]
        DevicePreferredConstantBufferSizeAmd = 0x4033,
        [NativeName("Name", "CL_DEVICE_PCIE_ID_AMD")]
        DevicePcieIDAmd = 0x4034,
    }
}
