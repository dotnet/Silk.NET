// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineLibraryCreateInfoKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public uint LibraryCount;

    [NativeTypeName("const VkPipeline *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public PipelineHandle* PLibraries;
}
