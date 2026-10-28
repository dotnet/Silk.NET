// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkInstanceCreateInfo")]
public unsafe partial struct InstanceCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.InstanceCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public InstanceCreateFlags Flags;

    [NativeName("pApplicationInfo")]
    public ApplicationInfo* PApplicationInfo;

    [NativeName("enabledLayerCount")]
    public uint EnabledLayerCount;

    [NativeName("ppEnabledLayerNames")]
    public sbyte** PpEnabledLayerNames;

    [NativeName("enabledExtensionCount")]
    public uint EnabledExtensionCount;

    [NativeName("ppEnabledExtensionNames")]
    public sbyte** PpEnabledExtensionNames;

    public InstanceCreateInfo() { }
}
