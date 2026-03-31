// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCuModuleTexturingModeCreateInfoNVX")]
[NameAffix("Suffix", "KhronosVendor", "NVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCuModuleTexturingModeCreateInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeName("use64bitTexturing")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint Use64BitTexturing;
}
