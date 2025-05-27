// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DebugUtilsLabelEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public void* PNext;

    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public sbyte* PLabelName;

    [NativeTypeName("float[4]")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    public DebugUtilsLabelEXTColor Color;
}
