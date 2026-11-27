// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExportMemoryWin32HandleInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExportMemoryWin32HandleInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.ExportMemoryWin32HandleInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("pAttributes")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public void PAttributes;

    [NativeName("dwAccess")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public uint DwAccess;

    [NativeName("name")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public ushort* Name;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_memory_win32"],
        ImpliesSets = [
            "VK_KHR_external_memory_win32+VK_KHR_external_memory",
            "VK_KHR_external_memory_win32+VK_VERSION_1_1",
        ]
    )]
    public ExportMemoryWin32HandleInfoKHR() { }
}
