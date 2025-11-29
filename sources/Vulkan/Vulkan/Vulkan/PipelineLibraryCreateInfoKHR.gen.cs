// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkPipelineLibraryCreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineLibraryCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public void* PNext;

    [NativeName("libraryCount")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public uint LibraryCount;

    [NativeName("pLibraries")]
    [SupportedApiProfile("vulkan", ["VK_KHR_pipeline_library"])]
    public Pipeline* PLibraries;
}
