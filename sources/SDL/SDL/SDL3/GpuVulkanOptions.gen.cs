// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUVulkanOptions")]
public unsafe partial struct GpuVulkanOptions
{
    [NativeName("vulkan_api_version")]
    public uint VulkanApiVersion;

    [NativeName("feature_list")]
    public void* FeatureList;

    [NativeName("vulkan_10_physical_device_features")]
    public void* Vulkan10PhysicalDeviceFeatures;

    [NativeName("device_extension_count")]
    public uint DeviceExtensionCount;

    [NativeName("device_extension_names")]
    public sbyte** DeviceExtensionNames;

    [NativeName("instance_extension_count")]
    public uint InstanceExtensionCount;

    [NativeName("instance_extension_names")]
    public sbyte** InstanceExtensionNames;
}
