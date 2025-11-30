// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugReportCallbackCreateInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugReportCallbackCreateInfoExt
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public DebugReportFlagsExt Flags;

    [NativeName("pfnCallback")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public DebugReportCallbackExt PfnCallback;

    [NativeName("pUserData")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    public void* PUserData;
}
