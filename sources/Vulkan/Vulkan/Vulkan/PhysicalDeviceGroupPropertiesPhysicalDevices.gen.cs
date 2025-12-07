// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
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
    public PhysicalDeviceHandle E0;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E1;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E2;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E3;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E4;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E5;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E6;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E7;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E8;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E9;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E10;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E11;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E12;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E13;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E14;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E15;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E16;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E17;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E18;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E19;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E20;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E21;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E22;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E23;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E24;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E25;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E26;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E27;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E28;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E29;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E30;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E31;

    [SupportedApiProfile("vulkan")]
    public ref PhysicalDeviceHandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDeviceHandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
