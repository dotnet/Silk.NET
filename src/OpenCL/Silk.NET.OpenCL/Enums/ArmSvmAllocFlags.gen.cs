// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_arm_svm_alloc_flags")]
    public enum ArmSvmAllocFlags : int
    {
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER_ARM")]
        MemSvmFineGrainBufferArm = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS_ARM")]
        MemSvmAtomicsArm = 0x800,
    }
}
