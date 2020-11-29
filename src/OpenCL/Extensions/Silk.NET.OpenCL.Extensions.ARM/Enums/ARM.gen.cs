// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [NativeName("Name", "GLenum")]
    public enum ARM
    {
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
        [NativeName("Name", "CL_PRINTF_CALLBACK_ARM")]
        PrintfCallbackArm = 0x40B0,
        [NativeName("Name", "CL_PRINTF_BUFFERSIZE_ARM")]
        PrintfBuffersizeArm = 0x40B1,
        [NativeName("Name", "CL_DEVICE_SCHEDULING_CONTROLS_CAPABILITIES_ARM")]
        DeviceSchedulingControlsCapabilitiesArm = 0x41E4,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_ARM")]
        KernelExecInfoWorkgroupBatchSizeArm = 0x41E5,
        [NativeName("Name", "CL_KERNEL_EXEC_INFO_WORKGROUP_BATCH_SIZE_MODIFIER_ARM")]
        KernelExecInfoWorkgroupBatchSizeModifierArm = 0x41E6,
        [NativeName("Name", "CL_QUEUE_KERNEL_BATCHING_ARM")]
        QueueKernelBatchingArm = 0x41E7,
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
        MemSvmFineGrainBufferArm = 0x1024,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS_ARM")]
        MemSvmAtomicsArm = 0x2048,
    }
}
