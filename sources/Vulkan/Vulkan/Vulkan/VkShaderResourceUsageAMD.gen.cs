// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderResourceUsageAMD")]
[NameAffix("Suffix", "KhronosVendor", "AMD")]
[SupportedApiProfile("vulkan")]
public partial struct VkShaderResourceUsageAMD
{
    [NativeName("numUsedVgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumUsedVgprs;

    [NativeName("numUsedSgprs")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumUsedSgprs;

    [NativeName("ldsSizePerLocalWorkGroup")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint LdsSizePerLocalWorkGroup;

    [NativeName("ldsUsageSizeInBytes")]
    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint LdsUsageSizeInBytes;

    [NativeName("scratchMemUsageInBytes")]
    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint ScratchMemUsageInBytes;
}
