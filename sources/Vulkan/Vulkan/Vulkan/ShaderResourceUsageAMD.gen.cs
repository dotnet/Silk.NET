// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "AMD", 0)]
[NativeName("VkShaderResourceUsageAMD")]
[SupportedApiProfile("vulkan")]
public partial struct ShaderResourceUsageAMD
{
    [NativeName("numUsedVgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumUsedVgprs;

    [NativeName("numUsedSgprs")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint NumUsedSgprs;

    [NativeName("ldsSizePerLocalWorkGroup")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public uint LdsSizePerLocalWorkGroup;

    [NativeName("ldsUsageSizeInBytes")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint LdsUsageSizeInBytes;

    [NativeName("scratchMemUsageInBytes")]
    [SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
    public nuint ScratchMemUsageInBytes;
}
