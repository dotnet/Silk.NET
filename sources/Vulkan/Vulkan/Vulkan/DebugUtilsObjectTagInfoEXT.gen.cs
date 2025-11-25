// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsObjectTagInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsObjectTagInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("objectType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ObjectType ObjectType;

    [NativeName("objectHandle")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong ObjectHandle;

    [NativeName("tagName")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong TagName;

    [NativeName("tagSize")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public nuint TagSize;

    [NativeName("pTag")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PTag;
}
