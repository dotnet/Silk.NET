// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "ARM")]
[NativeName("VkDataGraphPipelineSessionCreateFlagsARM")]
[Transformed]
[Flags]
public enum VkDataGraphPipelineSessionCreateFlagsARM : ulong
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "ARM")]
    [NativeName("VK_DATA_GRAPH_PIPELINE_SESSION_CREATE_PROTECTED_BIT_ARM")]
    VkDataGraphPipelineSessionCreateProtectedBit = unchecked((ulong)0x00000001UL),
}
