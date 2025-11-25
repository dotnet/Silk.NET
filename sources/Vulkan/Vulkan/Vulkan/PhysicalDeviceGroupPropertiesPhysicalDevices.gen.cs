// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_physicalDevices_e__FixedBuffer")]
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
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E0;

    [NativeName("e1")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E1;

    [NativeName("e2")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E2;

    [NativeName("e3")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E3;

    [NativeName("e4")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E4;

    [NativeName("e5")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E5;

    [NativeName("e6")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E6;

    [NativeName("e7")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E7;

    [NativeName("e8")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E8;

    [NativeName("e9")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E9;

    [NativeName("e10")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E10;

    [NativeName("e11")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E11;

    [NativeName("e12")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E12;

    [NativeName("e13")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E13;

    [NativeName("e14")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E14;

    [NativeName("e15")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E15;

    [NativeName("e16")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E16;

    [NativeName("e17")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E17;

    [NativeName("e18")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E18;

    [NativeName("e19")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E19;

    [NativeName("e20")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E20;

    [NativeName("e21")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E21;

    [NativeName("e22")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E22;

    [NativeName("e23")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E23;

    [NativeName("e24")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E24;

    [NativeName("e25")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E25;

    [NativeName("e26")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E26;

    [NativeName("e27")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E27;

    [NativeName("e28")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E28;

    [NativeName("e29")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E29;

    [NativeName("e30")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E30;

    [NativeName("e31")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceHandle E31;

    [SupportedApiProfile("vulkan")]
    public ref PhysicalDeviceHandle this[[NativeName("index")] int index]
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
