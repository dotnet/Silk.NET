// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportMemoryHostPointerInfoEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    public ExternalMemoryHandleTypeFlags HandleType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_external_memory_host"],
        ImpliesSets = [
            "VK_EXT_external_memory_host+VK_KHR_external_memory",
            "VK_EXT_external_memory_host+VK_VERSION_1_1",
        ]
    )]
    public void* PHostPointer;
}
