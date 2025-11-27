// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_physicalDevices_e__FixedBuffer")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceGroupPropertiesPhysicalDevices
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E0;

    [NativeName("e1")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E1;

    [NativeName("e2")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E2;

    [NativeName("e3")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E3;

    [NativeName("e4")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E4;

    [NativeName("e5")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E5;

    [NativeName("e6")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E6;

    [NativeName("e7")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E7;

    [NativeName("e8")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E8;

    [NativeName("e9")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E9;

    [NativeName("e10")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E10;

    [NativeName("e11")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E11;

    [NativeName("e12")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E12;

    [NativeName("e13")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E13;

    [NativeName("e14")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E14;

    [NativeName("e15")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E15;

    [NativeName("e16")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E16;

    [NativeName("e17")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E17;

    [NativeName("e18")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E18;

    [NativeName("e19")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E19;

    [NativeName("e20")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E20;

    [NativeName("e21")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E21;

    [NativeName("e22")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E22;

    [NativeName("e23")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E23;

    [NativeName("e24")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E24;

    [NativeName("e25")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E25;

    [NativeName("e26")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E26;

    [NativeName("e27")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E27;

    [NativeName("e28")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E28;

    [NativeName("e29")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E29;

    [NativeName("e30")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E30;

    [NativeName("e31")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice E31;

    [SupportedApiProfile("vulkan")]
    public ref PhysicalDevice this[[NativeName("index")] int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDevice* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
