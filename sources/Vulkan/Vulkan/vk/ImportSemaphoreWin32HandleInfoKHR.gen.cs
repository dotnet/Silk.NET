// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImportSemaphoreWin32HandleInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImportSemaphoreWin32HandleInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public StructureType SType = StructureType.ImportSemaphoreWin32HandleInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public void* PNext;

    [NativeName("semaphore")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public SemaphoreHandle Semaphore;

    [NativeName("flags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public SemaphoreImportFlags Flags;

    [NativeName("handleType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public ExternalSemaphoreHandleTypeFlags HandleType;

    [NativeName("handle")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public void* Handle;

    [NativeName("name")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public ushort* Name;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_semaphore_win32"],
        ImpliesSets = ["VK_KHR_external_semaphore"]
    )]
    public ImportSemaphoreWin32HandleInfoKHR() { }
}
