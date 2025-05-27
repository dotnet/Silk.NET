// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceGroupProperties
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public uint PhysicalDeviceCount;

    [NativeTypeName("VkPhysicalDevice[32]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public _physicalDevices_e__FixedBuffer PhysicalDevices;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public uint SubsetAllocation;

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    public unsafe partial struct _physicalDevices_e__FixedBuffer
    {
        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e0;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e1;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e2;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e3;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e4;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e5;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e6;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e7;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e8;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e9;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e10;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e11;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e12;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e13;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e14;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e15;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e16;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e17;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e18;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e19;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e20;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e21;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e22;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e23;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e24;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e25;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e26;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e27;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e28;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e29;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e30;

        [SupportedApiProfile("vulkan")]
        public PhysicalDeviceTHandle e31;

        [SupportedApiProfile("vulkan")]
        public ref PhysicalDeviceTHandle this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (PhysicalDeviceTHandle* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
