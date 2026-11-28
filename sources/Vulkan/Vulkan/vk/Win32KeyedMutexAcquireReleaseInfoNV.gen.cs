// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkWin32KeyedMutexAcquireReleaseInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct Win32KeyedMutexAcquireReleaseInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public StructureType SType = StructureType.Win32KeyedMutexAcquireReleaseInfoNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public void* PNext;

    [NativeName("acquireCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public uint AcquireCount;

    [NativeName("pAcquireSyncs")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public DeviceMemoryHandle* PAcquireSyncs;

    [NativeName("pAcquireKeys")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public ulong* PAcquireKeys;

    [NativeName("pAcquireTimeoutMilliseconds")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public uint* PAcquireTimeoutMilliseconds;

    [NativeName("releaseCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public uint ReleaseCount;

    [NativeName("pReleaseSyncs")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public DeviceMemoryHandle* PReleaseSyncs;

    [NativeName("pReleaseKeys")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public ulong* PReleaseKeys;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_win32_keyed_mutex"],
        ImpliesSets = ["VK_NV_external_memory_win32"]
    )]
    public Win32KeyedMutexAcquireReleaseInfoNV() { }
}
