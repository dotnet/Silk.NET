// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ValidationFlagsEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public uint DisabledValidationCheckCount;

    [NativeTypeName("const VkValidationCheckEXT *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    public ValidationCheckEXT* PDisabledValidationChecks;
}
