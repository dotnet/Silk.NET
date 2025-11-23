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
    public PhysicalDeviceTHandle E0;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E1;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E2;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E3;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E4;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E5;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E6;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E7;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E8;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E9;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E10;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E11;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E12;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E13;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E14;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E15;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E16;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E17;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E18;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E19;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E20;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E21;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E22;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E23;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E24;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E25;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E26;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E27;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E28;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E29;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E30;

    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceTHandle E31;

    [SupportedApiProfile("vulkan")]
    public ref PhysicalDeviceTHandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDeviceTHandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
