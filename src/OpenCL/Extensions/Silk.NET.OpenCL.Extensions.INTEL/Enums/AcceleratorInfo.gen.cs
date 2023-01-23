// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_accelerator_info_intel")]
    public enum AcceleratorInfo : int
    {
        [NativeName("Name", "CL_ACCELERATOR_DESCRIPTOR_INTEL")]
        Descriptor = 0x4090,
        [NativeName("Name", "CL_ACCELERATOR_REFERENCE_COUNT_INTEL")]
        ReferenceCount = 0x4091,
        [NativeName("Name", "CL_ACCELERATOR_CONTEXT_INTEL")]
        Context = 0x4092,
        [NativeName("Name", "CL_ACCELERATOR_TYPE_INTEL")]
        Type = 0x4093,
    }
}
