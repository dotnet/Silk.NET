// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportMemoryWin32HandleInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportMemoryWin32HandleInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    public StructureType SType = StructureType.ImportMemoryWin32HandleInfoNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    public void* PNext;

    [NativeName("handleType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    public ExternalMemoryHandleTypeFlagsNV HandleType;

    [NativeName("handle")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    public void* Handle;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_external_memory_win32"],
        ImpliesSets = ["VK_NV_external_memory"]
    )]
    public ImportMemoryWin32HandleInfoNV() { }
}
