// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(3)]
[SupportedApiProfile("vulkan", ["VK_AMD_shader_info"])]
public partial struct VkShaderStatisticsInfoAMD_computeWorkGroupSize
{
    [SupportedApiProfile("vulkan")]
    public uint e0;
}
