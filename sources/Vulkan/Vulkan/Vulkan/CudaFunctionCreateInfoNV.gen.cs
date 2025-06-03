// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CudaFunctionCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public void* PNext;

    [NativeTypeName("VkCudaModuleNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public CudaModuleNVHandle Module;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cuda_kernel_launch"])]
    public sbyte* PName;
}
