// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderSMBuiltinsFeaturesNV")]
[NameAffix("Suffix", "KhronosVendor", "NV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    public void* PNext;

    [NativeName("shaderSMBuiltins")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_shader_sm_builtins"], ImpliesSets = ["VK_VERSION_1_1"])]
    public uint ShaderSMBuiltins;
}
