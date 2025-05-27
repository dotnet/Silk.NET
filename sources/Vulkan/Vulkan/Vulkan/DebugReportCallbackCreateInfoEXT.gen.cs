// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugReportCallbackCreateInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* PNext;

    [NativeTypeName("VkDebugReportFlagsEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public uint Flags;

    [NativeTypeName("PFN_vkDebugReportCallbackEXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public delegate* unmanaged<
        uint,
        DebugReportObjectTypeEXT,
        ulong,
        nuint,
        int,
        sbyte*,
        sbyte*,
        void*,
        uint> PfnCallback;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* PUserData;
}
