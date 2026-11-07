// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerAddressMode")]
public enum SamplerAddressMode : uint
{
    [NativeName("VK_SAMPLER_ADDRESS_MODE_REPEAT")]
    Repeat = 0,

    [NativeName("VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT")]
    MirroredRepeat = 1,

    [NativeName("VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE")]
    ClampToEdge = 2,

    [NativeName("VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER")]
    ClampToBorder = 3,

    [NativeName("VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE")]
    MirrorClampToEdge = 4,
}
