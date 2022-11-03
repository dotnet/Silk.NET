// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [System.Flags]
    [NativeName("Name", "cl_device_svm_capabilities_arm")]
    public enum DeviceSvmCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_SVM_COARSE_GRAIN_BUFFER_ARM")]
        CoarseGrainBuffer = 0x1,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_BUFFER_ARM")]
        FineGrainBuffer = 0x2,
        [NativeName("Name", "CL_DEVICE_SVM_FINE_GRAIN_SYSTEM_ARM")]
        FineGrainSystem = 0x4,
        [NativeName("Name", "CL_DEVICE_SVM_ATOMICS_ARM")]
        Atomics = 0x8,
    }
}
