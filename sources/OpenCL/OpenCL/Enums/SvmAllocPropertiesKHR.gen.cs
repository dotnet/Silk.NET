// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_svm_alloc_properties_khr")]
public enum SvmAllocPropertiesKHR : ulong
{
    [NativeName("CL_SVM_ALLOC_ASSOCIATED_DEVICE_HANDLE_KHR")]
    AssociatedDeviceHandle = 8312,

    [NativeName("CL_SVM_ALLOC_ACCESS_FLAGS_KHR")]
    AccessFlags = 8313,

    [NativeName("CL_SVM_ALLOC_ALIGNMENT_KHR")]
    Alignment = 8314,

    [NativeName("CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_VIRTUAL_ADDRESS_IMG")]
    ExternalMemoryDmaBufVirtualAddressIMG = 16928,

    [NativeName("CL_SVM_ALLOC_EXTERNAL_MEMORY_DMA_BUF_IMG")]
    ExternalMemoryDmaBufIMG = 16929,
}
