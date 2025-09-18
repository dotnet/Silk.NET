// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DirectDriverLoadingListLunarg
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public void* PNext;

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public DirectDriverLoadingModeLunarg Mode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public uint DriverCount;

    [NativeTypeName("const VkDirectDriverLoadingInfoLUNARG *")]
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    public DirectDriverLoadingInfoLunarg* PDrivers;
}
