// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[InlineArray(2)]
[SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
public partial struct VkImageBlit2_srcOffsets
{
    [SupportedApiProfile("vulkan")]
    public VkOffset3D e0;
}
