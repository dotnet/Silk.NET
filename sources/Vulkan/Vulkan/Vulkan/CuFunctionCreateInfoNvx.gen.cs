// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NVX", 0)]
[NativeName("VkCuFunctionCreateInfoNVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CuFunctionCreateInfoNvx
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeName("module")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public CuModuleHandleNvx Module;

    [NativeName("pName")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public sbyte* PName;
}
