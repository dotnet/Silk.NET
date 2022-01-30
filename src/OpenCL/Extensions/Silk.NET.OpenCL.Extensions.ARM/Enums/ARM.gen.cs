// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [NativeName("Name", "GLenum")]
    public enum ARM : int
    {
        [NativeName("Name", "CL_COMMAND_TERMINATED_ITSELF_WITH_FAILURE_ARM")]
        CommandTerminatedItselfWithFailureArm = unchecked((int)0xFFFFFFFFFFFFFBAC),
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_SUCCESS_ARM")]
        DeviceControlledTerminationSuccessArm = 0x1,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_FAILURE_ARM")]
        DeviceControlledTerminationFailureArm = 0x2,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_QUERY_ARM")]
        DeviceControlledTerminationQueryArm = 0x4,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_CAPABILITIES_ARM")]
        DeviceControlledTerminationCapabilitiesArm = 0x41EE,
        [NativeName("Name", "CL_EVENT_COMMAND_TERMINATION_REASON_ARM")]
        EventCommandTerminationReasonArm = 0x41ED,
        [NativeName("Name", "CL_COMMAND_TERMINATION_COMPLETION_ARM")]
        CommandTerminationCompletionArm = 0x0,
        [NativeName("Name", "CL_COMMAND_TERMINATION_CONTROLLED_SUCCESS_ARM")]
        CommandTerminationControlledSuccessArm = 0x1,
        [NativeName("Name", "CL_COMMAND_TERMINATION_CONTROLLED_FAILURE_ARM")]
        CommandTerminationControlledFailureArm = 0x2,
        [NativeName("Name", "CL_COMMAND_TERMINATION_ERROR_ARM")]
        CommandTerminationErrorArm = 0x3,
        [NativeName("Name", "CL_DEVICE_COMPUTE_UNITS_BITFIELD_ARM")]
        DeviceComputeUnitsBitfieldArm = 0x40BF,
        [NativeName("Name", "CL_IMPORT_TYPE_ARM")]
        ImportTypeArm = 0x40B2,
        [NativeName("Name", "CL_IMPORT_TYPE_HOST_ARM")]
        ImportTypeHostArm = 0x40B3,
        [NativeName("Name", "CL_IMPORT_TYPE_DMA_BUF_ARM")]
        ImportTypeDmaBufArm = 0x40B4,
        [NativeName("Name", "CL_IMPORT_TYPE_PROTECTED_ARM")]
        ImportTypeProtectedArm = 0x40B5,
        [NativeName("Name", "CL_IMPORT_TYPE_ANDROID_HARDWARE_BUFFER_ARM")]
        ImportTypeAndroidHardwareBufferArm = 0x41E2,
        [NativeName("Name", "CL_IMPORT_DMA_BUF_DATA_CONSISTENCY_WITH_HOST_ARM")]
        ImportDmaBufDataConsistencyWithHostArm = 0x41E3,
        [NativeName("Name", "CL_IMPORT_MEMORY_WHOLE_ALLOCATION_ARM")]
        ImportMemoryWholeAllocationArm = -1,
        [NativeName("Name", "CL_IMPORT_ANDROID_HARDWARE_BUFFER_PLANE_INDEX_ARM")]
        ImportAndroidHardwareBufferPlaneIndexArm = 0x41EF,
        [NativeName("Name", "CL_IMPORT_ANDROID_HARDWARE_BUFFER_LAYER_INDEX_ARM")]
        ImportAndroidHardwareBufferLayerIndexArm = 0x41F0,
        [NativeName("Name", "CL_PRINTF_CALLBACK_ARM")]
        PrintfCallbackArm = 0x40B0,
        [NativeName("Name", "CL_PRINTF_BUFFERSIZE_ARM")]
        PrintfBuffersizeArm = 0x40B1,
        [NativeName("Name", "CL_MEM_PROTECTED_ALLOC_ARM")]
        MemProtectedAllocArm = unchecked((int)0x1000000000),
        [NativeName("Name", "CL_DEVICE_SCHEDULING_KERNEL_BATCHING_ARM")]
        DeviceSchedulingKernelBatchingArm = 0x1,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_ARM")]
        DeviceSchedulingWorkgroupBatchSizeArm = 0x2,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        DeviceSchedulingWorkgroupBatchSizeModifierArm = 0x4,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_DEFERRED_FLUSH_ARM")]
        DeviceSchedulingDeferredFlushArm = 0x8,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_REGISTER_ALLOCATION_ARM")]
        DeviceSchedulingRegisterAllocationArm = 0x10,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        DeviceSchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_DEVICE_SUPPORTED_REGISTER_ALLOCATIONS_ARM")]
        DeviceSupportedRegisterAllocationsArm = 0x41EB,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
        KernelExecInfoWorkgroupBatchSizeArm = 0x41E5,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        KernelExecInfoWorkgroupBatchSizeModifierArm = 0x41E6,
        [NativeName("Name", "CL_QUEUE_KERNEL_BATCHING_ARM")]
        QueueKernelBatchingArm = 0x41E7,
        [NativeName("Name", "CL_QUEUE_DEFERRED_FLUSH_ARM")]
        QueueDeferredFlushArm = 0x41EC,
        [NativeName("Name", "CL_DEVICE_SVM_CAPABILITIES_ARM")]
        DeviceSvmCapabilitiesArm = 0x40B6,
        [NativeName("Name", "CL_MEM_USES_SVM_POINTER_ARM")]
        MemUsesSvmPointerArm = 0x40B7,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_PTRS_ARM")]
        KernelExecInfoSvmPtrsArm = 0x40B8,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_SVM_FINE_GRAIN_SYSTEM_ARM")]
        KernelExecInfoSvmFineGrainSystemArm = 0x40B9,
        [NativeName("Name", "CL_COMMAND_SVM_FREE_ARM")]
        CommandSvmFreeArm = 0x40BA,
        [NativeName("Name", "CL_COMMAND_SVM_MEMCPY_ARM")]
        CommandSvmMemcpyArm = 0x40BB,
        [NativeName("Name", "CL_COMMAND_SVM_MEMFILL_ARM")]
        CommandSvmMemfillArm = 0x40BC,
        [NativeName("Name", "CL_COMMAND_SVM_MAP_ARM")]
        CommandSvmMapArm = 0x40BD,
        [NativeName("Name", "CL_COMMAND_SVM_UNMAP_ARM")]
        CommandSvmUnmapArm = 0x40BE,
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER_ARM")]
        DeviceSvmCoarseGrainBufferArm = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER_ARM")]
        DeviceSvmFineGrainBufferArm = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM_ARM")]
        DeviceSvmFineGrainSystemArm = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS_ARM")]
        DeviceSvmAtomicsArm = 0x8,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER_ARM")]
        MemSvmFineGrainBufferArm = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS_ARM")]
        MemSvmAtomicsArm = 0x800,
    }
}
