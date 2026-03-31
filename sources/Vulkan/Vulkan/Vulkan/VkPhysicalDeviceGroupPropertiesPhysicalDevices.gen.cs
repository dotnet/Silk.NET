// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_physicalDevices_e__FixedBuffer")]
[NameAffix("Prefix", "NestedStructParent", nameof(VkPhysicalDeviceGroupProperties))]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceGroupPropertiesPhysicalDevices
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E0;

    [NativeName("e1")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E1;

    [NativeName("e2")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E2;

    [NativeName("e3")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E3;

    [NativeName("e4")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E4;

    [NativeName("e5")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E5;

    [NativeName("e6")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E6;

    [NativeName("e7")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E7;

    [NativeName("e8")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E8;

    [NativeName("e9")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E9;

    [NativeName("e10")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E10;

    [NativeName("e11")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E11;

    [NativeName("e12")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E12;

    [NativeName("e13")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E13;

    [NativeName("e14")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E14;

    [NativeName("e15")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E15;

    [NativeName("e16")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E16;

    [NativeName("e17")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E17;

    [NativeName("e18")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E18;

    [NativeName("e19")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E19;

    [NativeName("e20")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E20;

    [NativeName("e21")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E21;

    [NativeName("e22")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E22;

    [NativeName("e23")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E23;

    [NativeName("e24")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E24;

    [NativeName("e25")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E25;

    [NativeName("e26")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E26;

    [NativeName("e27")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E27;

    [NativeName("e28")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E28;

    [NativeName("e29")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E29;

    [NativeName("e30")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E30;

    [NativeName("e31")]
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDeviceHandle E31;

    [SupportedApiProfile("vulkan")]
    public ref VkPhysicalDeviceHandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (VkPhysicalDeviceHandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
