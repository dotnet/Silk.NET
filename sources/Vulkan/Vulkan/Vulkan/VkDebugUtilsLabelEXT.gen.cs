// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsLabelEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* pNext;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* pLabelName;

    [NativeTypeName("float[4]")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkDebugUtilsLabelEXT_color color;
}
