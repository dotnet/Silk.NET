// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ExternalMemoryImageCreateInfoNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    public void* PNext;

    [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory"],
        ImpliesSets = ["VK_NV_external_memory_capabilities"]
    )]
    public ExternalMemoryHandleTypeFlagsNV HandleTypes;
}
