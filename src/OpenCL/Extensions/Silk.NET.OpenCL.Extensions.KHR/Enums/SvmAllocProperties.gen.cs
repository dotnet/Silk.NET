// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_svm_alloc_properties_khr")]
    public enum SvmAllocProperties : ulong
    {
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_VIRTUAL_ADDRESS_IMG")]
        ExternalMemoryDmaBufVirtualAddressImg = 0x4220,
        [NativeName("Name", "CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_IMG")]
        ExternalMemoryDmaBufImg = 0x4221,
        [NativeName("Name", "CL_SVM_ALLOC_ASSOCIATED_DEVICE_HANDLE_KHR")]
        AssociatedDeviceHandle = 0x2078,
        [NativeName("Name", "CL_SVM_ALLOC_ACCESS_FLAGS_KHR")]
        AccessFlags = 0x2079,
        [NativeName("Name", "CL_SVM_ALLOC_ALIGNMENT_KHR")]
        Alignment = 0x207A,
    }
}
