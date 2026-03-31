// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationFlagsEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkValidationFlagsEXT
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public void* PNext;

    [NativeName("disabledValidationCheckCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public uint DisabledValidationCheckCount;

    [NativeName("pDisabledValidationChecks")]
    [NativeTypeName("const VkValidationCheckEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public VkValidationCheckEXT* PDisabledValidationChecks;
}
