// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [System.Flags]
    [NativeName("Name", "cl_svm_mem_flags_arm")]
    public enum SvmMemFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MEM_SVM_FINE_GRAIN_BUFFER_ARM")]
        FineGrainBuffer = 0x400,
        [NativeName("Name", "CL_MEM_SVM_ATOMICS_ARM")]
        Atomics = 0x800,
    }
}
