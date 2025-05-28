// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsObjectTagInfoEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ObjectType ObjectType;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong ObjectHandle;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public ulong TagName;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public nuint TagSize;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PTag;
}
