// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDebugUtilsObjectNameInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsObjectNameInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType = StructureType.DebugUtilsObjectNameInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeName("objectType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ObjectType ObjectType;

    [NativeName("objectHandle")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong ObjectHandle;

    [NativeName("pObjectName")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PObjectName;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsObjectNameInfoEXT() { }
}
