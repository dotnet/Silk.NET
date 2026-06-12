// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPushConstantBankInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PushConstantBankInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public StructureType SType = StructureType.PushConstantBankInfoNV;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public void* PNext;

    [NativeName("bank")]
    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public uint Bank;

    [SupportedApiProfile("vulkan", ["VK_NV_push_constant_bank"])]
    public PushConstantBankInfoNV() { }
}
