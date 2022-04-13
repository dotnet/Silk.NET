// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_arm_device_svm_capabilities_flags")]
    public enum ArmDeviceSvmCapabilitiesFlags : int
    {
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER_ARM")]
        DeviceSvmCoarseGrainBufferArm = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER_ARM")]
        DeviceSvmFineGrainBufferArm = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM_ARM")]
        DeviceSvmFineGrainSystemArm = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS_ARM")]
        DeviceSvmAtomicsArm = 0x8,
    }
}
