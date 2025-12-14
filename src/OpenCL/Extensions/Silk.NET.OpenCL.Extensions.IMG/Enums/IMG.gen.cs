// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Obsolete("The \"ungrouped\" enums (CLEnum, KHR, etc...) are deprecated in favour of the \"grouped\" enums (ErrorCodes, DeviceType, etc...). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ")]
    [Flags]
    [NativeName("Name", "CLenum")]
    public enum IMG : int
    {
        [NativeName("Name", "CL_CONTEXT_WORKGROUP_PROTECTION_IMG")]
        WorkgroupProtection = 0x1,
        [NativeName("Name", "CL_CONTEXT_WORKGROUP_PROTECTION_IMG")]
        ContextWorkgroupProtectionImg = 0x1,
        [NativeName("Name", "CL_CONTEXT_ENHANCED_EVENT_EXECUTION_STATUS_IMG")]
        EnhancedEventExecutionStatus = 0x2,
        [NativeName("Name", "CL_CONTEXT_ENHANCED_EVENT_EXECUTION_STATUS_IMG")]
        ContextEnhancedEventExecutionStatusImg = 0x2,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_LINEAR_ORDER_IMG")]
        SchedulingAlgorithmLinearOrder = 0x1,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_LINEAR_ORDER_IMG")]
        DeviceWorkGroupSchedulingAlgorithmLinearOrderImg = 0x1,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_MORTON_ORDER_IMG")]
        SchedulingAlgorithmMortonOrder = 0x2,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_MORTON_ORDER_IMG")]
        DeviceWorkGroupSchedulingAlgorithmMortonOrderImg = 0x2,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_TWOD_MORTON_ORDER_IMG")]
        SchedulingAlgorithmTwodMortonOrder = 0x4,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_TWOD_MORTON_ORDER_IMG")]
        DeviceWorkGroupSchedulingAlgorithmTwodMortonOrderImg = 0x4,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_THREED_MORTON_ORDER_IMG")]
        SchedulingAlgorithmThreedMortonOrder = 0x8,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_SCHEDULING_ALGORITHM_THREED_MORTON_ORDER_IMG")]
        DeviceWorkGroupSchedulingAlgorithmThreedMortonOrderImg = 0x8,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_TASK_DEMAND_IMG")]
        ArbitrationAlgorithmTaskDemand = 0x100,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_TASK_DEMAND_IMG")]
        DeviceWorkGroupArbitrationAlgorithmTaskDemandImg = 0x100,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_ROUND_ROBIN_IMG")]
        ArbitrationAlgorithmRoundRobin = 0x200,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_ARBITRATION_ALGORITHM_ROUND_ROBIN_IMG")]
        DeviceWorkGroupArbitrationAlgorithmRoundRobinImg = 0x200,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_EXECUTE_COUNT_IMG")]
        ExecuteCount = 0x400,
        [NativeName("Name", "CL_DEVICE_WORK_GROUP_EXECUTE_COUNT_IMG")]
        DeviceWorkGroupExecuteCountImg = 0x400,
        [NativeName("Name", "CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
        RelaxRequirements = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
        MemAllocRelaxRequirementsImg = 0x1,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_WRITE_COMBINE_IMG")]
        GpuWriteCombine = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_WRITE_COMBINE_IMG")]
        MemAllocGpuWriteCombineImg = 0x2,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_CACHED_IMG")]
        GpuCached = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_CACHED_IMG")]
        MemAllocGpuCachedImg = 0x4,
        [NativeName("Name", "CL_MEM_ALLOC_CPU_LOCAL_IMG")]
        CpuLocal = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_CPU_LOCAL_IMG")]
        MemAllocCpuLocalImg = 0x8,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_LOCAL_IMG")]
        GpuLocal = 0x10,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_LOCAL_IMG")]
        MemAllocGpuLocalImg = 0x10,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_PRIVATE_IMG")]
        GpuPrivate = 0x20,
        [NativeName("Name", "CL_MEM_ALLOC_GPU_PRIVATE_IMG")]
        MemAllocGpuPrivateImg = 0x20,
        [NativeName("Name", "CL_MIPMAP_FILTER_ANY_IMG")]
        Any = 0x0,
        [NativeName("Name", "CL_MIPMAP_FILTER_ANY_IMG")]
        MipmapFilterAnyImg = 0x0,
        [NativeName("Name", "CL_MIPMAP_FILTER_BOX_IMG")]
        Box = 0x1,
        [NativeName("Name", "CL_MIPMAP_FILTER_BOX_IMG")]
        MipmapFilterBoxImg = 0x1,
        [NativeName("Name", "CL_NV21_IMG")]
        NV21Img = 0x40D0,
        [NativeName("Name", "CL_YV12_IMG")]
        YV12Img = 0x40D1,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        AcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_ACQUIRE_GRALLOC_OBJECTS_IMG")]
        CommandAcquireGrallocObjectsImg = 0x40D2,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        ReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_RELEASE_GRALLOC_OBJECTS_IMG")]
        CommandReleaseGrallocObjectsImg = 0x40D3,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        GenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_COMMAND_GENERATE_MIPMAP_IMG")]
        CommandGenerateMipmapImg = 0x40D6,
        [NativeName("Name", "CL_CONTEXT_SAFETY_PROPERTIES_IMG")]
        SafetyPropertiesImg = 0x40D9,
        [NativeName("Name", "CL_CONTEXT_SAFETY_PROPERTIES_IMG")]
        ContextSafetyPropertiesImg = 0x40D9,
        [NativeName("Name", "CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
        MemoryCapabilitiesImg = 0x40D8,
        [NativeName("Name", "CL_DEVICE_MEMORY_CAPABILITIES_IMG")]
        DeviceMemoryCapabilitiesImg = 0x40D8,
        [NativeName("Name", "CL_DEVICE_WORKGROUP_PROTECTION_SVM_CAPABILITIES_IMG")]
        WorkgroupProtectionSvmCapabilitiesImg = 0x40DA,
        [NativeName("Name", "CL_DEVICE_WORKGROUP_PROTECTION_SVM_CAPABILITIES_IMG")]
        DeviceWorkgroupProtectionSvmCapabilitiesImg = 0x40DA,
        [NativeName("Name", "CL_DEVICE_WORKGROUP_PROTECTION_DEVICE_ENQUEUE_CAPABILITIES_IMG")]
        WorkgroupProtectionDeviceEnqueueCapabilitiesImg = 0x40DB,
        [NativeName("Name", "CL_DEVICE_WORKGROUP_PROTECTION_DEVICE_ENQUEUE_CAPABILITIES_IMG")]
        DeviceWorkgroupProtectionDeviceEnqueueCapabilitiesImg = 0x40DB,
        [NativeName("Name", "CL_DEVICE_SAFETY_MEM_SIZE_IMG")]
        SafetyMemSizeImg = 0x40DC,
        [NativeName("Name", "CL_DEVICE_SAFETY_MEM_SIZE_IMG")]
        DeviceSafetyMemSizeImg = 0x40DC,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_IMG")]
        SchedulingControlsCapabilitiesImg = 0x4222,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_IMG")]
        DeviceSchedulingControlsCapabilitiesImg = 0x4222,
        [NativeName("Name", "CL_GRALLOC_RESOURCE_NOT_ACQUIRED_IMG")]
        GrallocResourceNotAcquiredImg = 0x40D4,
        [NativeName("Name", "CL_INVALID_GRALLOC_OBJECT_IMG")]
        InvalidGrallocObjectImg = 0x40D5,
        [NativeName("Name", "CL_ECC_RECOVERED_IMG")]
        EccRecoveredImg = 0x40DD,
        [NativeName("Name", "CL_PAGE_FAULT_IMG")]
        PageFaultImg = unchecked((int) 0xFFFFFFFFFFFFFB99),
        [NativeName("Name", "CL_SAFETY_FAULT_IMG")]
        SafetyFaultImg = unchecked((int) 0xFFFFFFFFFFFFFB98),
        [NativeName("Name", "CL_GENERAL_FAULT_IMG")]
        GeneralFaultImg = unchecked((int) 0xFFFFFFFFFFFFFB97),
        [NativeName("Name", "CL_ECC_UNRECOVERED_IMG")]
        EccUnrecoveredImg = unchecked((int) 0xFFFFFFFFFFFFFB96),
        [NativeName("Name", "CL_CANCELLED_IMG")]
        CancelledImg = unchecked((int) 0xFFFFFFFFFFFFFB9A),
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        UseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_UNCACHED_CPU_MEMORY_IMG")]
        MemUseUncachedCpuMemoryImg = 0x4000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        UseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_CACHED_CPU_MEMORY_IMG")]
        MemUseCachedCpuMemoryImg = 0x8000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        UseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_USE_GRALLOC_PTR_IMG")]
        MemUseGrallocPtrImg = 0x10000000,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        AllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_MEM_ALLOC_FLAGS_IMG")]
        MemAllocFlagsImg = 0x40D7,
        [NativeName("Name", "CL_COMMAND_QUEUE_SCHEDULING_WORK_GROUP_SCHEDULING_ALGORITHM_IMG")]
        CommandQueueSchedulingWorkGroupSchedulingAlgorithmImg = 0x4223,
        [NativeName("Name", "CL_COMMAND_QUEUE_SCHEDULING_WORK_GROUP_ARBITRATION_ALGORITHM_IMG")]
        CommandQueueSchedulingWorkGroupArbitrationAlgorithmImg = 0x4224,
        [NativeName("Name", "CL_COMMAND_QUEUE_SCHEDULING_WORK_GROUP_EXECUTE_COUNT_IMG")]
        CommandQueueSchedulingWorkGroupExecuteCountImg = 0x422B,
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_VIRTUAL_ADDRESS_IMG")]
        ExternalMemoryDmaBufVirtualAddressImg = 0x4220,
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_VIRTUAL_ADDRESS_IMG")]
        SvmAllocExternalMemoryDmaBufVirtualAddressImg = 0x4220,
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_IMG")]
        ExternalMemoryDmaBufImg = 0x4221,
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_IMG")]
        SvmAllocExternalMemoryDmaBufImg = 0x4221,
    }
}
