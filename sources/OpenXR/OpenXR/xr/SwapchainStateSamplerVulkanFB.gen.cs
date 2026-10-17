// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainStateSamplerVulkanFB")]
public unsafe partial struct SwapchainStateSamplerVulkanFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.SwapchainStateSamplerVulkanFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("minFilter")]
    public VkFilter MinFilter;

    [NativeName("magFilter")]
    public VkFilter MagFilter;

    [NativeName("mipmapMode")]
    public VkSamplerMipmapMode MipmapMode;

    [NativeName("wrapModeS")]
    public VkSamplerAddressMode WrapModeS;

    [NativeName("wrapModeT")]
    public VkSamplerAddressMode WrapModeT;

    [NativeName("swizzleRed")]
    public VkComponentSwizzle SwizzleRed;

    [NativeName("swizzleGreen")]
    public VkComponentSwizzle SwizzleGreen;

    [NativeName("swizzleBlue")]
    public VkComponentSwizzle SwizzleBlue;

    [NativeName("swizzleAlpha")]
    public VkComponentSwizzle SwizzleAlpha;

    [NativeName("maxAnisotropy")]
    public float MaxAnisotropy;

    [NativeName("borderColor")]
    public Color4F BorderColor;

    public SwapchainStateSamplerVulkanFB() { }
}
