// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile(
    "vulkan",
    [
        "VK_BASE_VERSION_1_1",
        "VK_BASE_VERSION_1_2",
        "VK_BASE_VERSION_1_3",
        "VK_BASE_VERSION_1_4",
        "VK_COMPUTE_VERSION_1_1",
        "VK_COMPUTE_VERSION_1_2",
        "VK_COMPUTE_VERSION_1_3",
        "VK_COMPUTE_VERSION_1_4",
        "VK_GRAPHICS_VERSION_1_1",
        "VK_GRAPHICS_VERSION_1_2",
        "VK_GRAPHICS_VERSION_1_3",
        "VK_GRAPHICS_VERSION_1_4",
        "VK_VERSION_1_1",
        "VK_VERSION_1_2",
        "VK_VERSION_1_3",
        "VK_VERSION_1_4",
    ],
    MinVersion = "1.1"
)]
public unsafe partial struct PhysicalDeviceGroupPropertiesPhysicalDevices
{
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E0;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E1;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E2;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E3;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E4;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E5;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E6;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E7;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E8;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E9;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E10;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E11;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E12;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E13;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E14;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E15;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E16;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E17;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E18;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E19;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E20;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E21;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E22;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E23;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E24;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E25;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E26;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E27;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E28;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E29;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E30;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_THandle E31;

    [SupportedApiProfile("vulkan")]
    public ref VkPhysicalDevice_THandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (VkPhysicalDevice_THandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
