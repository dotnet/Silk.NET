// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsObjectNameInfoEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDebugUtilsObjectNameInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("objectType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public VkObjectType ObjectType;

    [NativeName("objectHandle")]
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong ObjectHandle;

    [NativeName("pObjectName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PObjectName;
}
