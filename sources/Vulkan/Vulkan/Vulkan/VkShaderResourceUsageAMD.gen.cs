// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkShaderResourceUsageAMD
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numUsedVgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint numUsedSgprs;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint ldsSizePerLocalWorkGroup;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint ldsUsageSizeInBytes;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint scratchMemUsageInBytes;
}
