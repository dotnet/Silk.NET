// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCuFunctionCreateInfoNVX")]
[NameAffix("Suffix", "KhronosVendor", "NVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCuFunctionCreateInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeName("module")]
    [NativeTypeName("VkCuModuleNVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkCuModuleHandleNVX Module;

    [NativeName("pName")]
    [NativeTypeName("const char *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public sbyte* PName;
}
