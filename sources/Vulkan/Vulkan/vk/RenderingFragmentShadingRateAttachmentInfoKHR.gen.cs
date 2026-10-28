// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingFragmentShadingRateAttachmentInfoKHR")]
public unsafe partial struct RenderingFragmentShadingRateAttachmentInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderingFragmentShadingRateAttachmentInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("imageView")]
    public ImageViewHandle ImageView;

    [NativeName("imageLayout")]
    public ImageLayout ImageLayout;

    [NativeName("shadingRateAttachmentTexelSize")]
    public Extent2D ShadingRateAttachmentTexelSize;

    public RenderingFragmentShadingRateAttachmentInfoKHR() { }
}
