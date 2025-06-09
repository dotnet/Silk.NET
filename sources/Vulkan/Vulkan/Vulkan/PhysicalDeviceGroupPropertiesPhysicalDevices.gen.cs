// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
global using Silk.NET.Core;
global using static Silk.NET.Core.DSL;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile(
    "vulkan",
    ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
    MinVersion = "1.1"
)]
public unsafe partial struct PhysicalDeviceGroupPropertiesPhysicalDevices
{
    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E0;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E1;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E2;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E3;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E4;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E5;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E6;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E7;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E8;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E9;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E10;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E11;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E12;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E13;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E14;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E15;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E16;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E17;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E18;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E19;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E20;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E21;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E22;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E23;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E24;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E25;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E26;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E27;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E28;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E29;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E30;

    [SupportedApiProfile("vulkan")]
    public PhysicalDevice* E31;

    [SupportedApiProfile("vulkan")]
    public ref PhysicalDevice* this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDevice** pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
