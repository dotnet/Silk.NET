// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    public enum ARM
    {
        DeviceComputeUnitsBitfieldArm = 0x40BF,
        ImportTypeArm = 0x40B2,
        ImportTypeHostArm = 0x40B3,
        ImportTypeDmaBufArm = 0x40B4,
        ImportTypeProtectedArm = 0x40B5,
        PrintfCallbackArm = 0x40B0,
        PrintfBuffersizeArm = 0x40B1,
        DeviceSchedulingControlsCapabilitiesArm = 0x41E4,
        KernelExecInfoWorkgroupBatchSizeArm = 0x41E5,
        KernelExecInfoWorkgroupBatchSizeModifierArm = 0x41E6,
        QueueKernelBatchingArm = 0x41E7,
        DeviceSvmCapabilitiesArm = 0x40B6,
        MemUsesSvmPointerArm = 0x40B7,
        KernelExecInfoSvmPtrsArm = 0x40B8,
        KernelExecInfoSvmFineGrainSystemArm = 0x40B9,
        CommandSvmFreeArm = 0x40BA,
        CommandSvmMemcpyArm = 0x40BB,
        CommandSvmMemfillArm = 0x40BC,
        CommandSvmMapArm = 0x40BD,
        CommandSvmUnmapArm = 0x40BE,
        DeviceSvmCoarseGrainBufferArm = 0x1,
        DeviceSvmFineGrainBufferArm = 0x2,
        DeviceSvmFineGrainSystemArm = 0x4,
        DeviceSvmAtomicsArm = 0x8,
        MemSvmFineGrainBufferArm = 0x1024,
        MemSvmAtomicsArm = 0x2048,
    }
}
