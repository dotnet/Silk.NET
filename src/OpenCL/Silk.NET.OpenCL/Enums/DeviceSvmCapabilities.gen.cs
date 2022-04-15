// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_svm_capabilities")]
    public enum DeviceSvmCapabilities : ulong
    {
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER")]
        DeviceSvmCoarseGrainBuffer = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER")]
        DeviceSvmFineGrainBuffer = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM")]
        DeviceSvmFineGrainSystem = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS")]
        DeviceSvmAtomics = 0x8,
    }
}
