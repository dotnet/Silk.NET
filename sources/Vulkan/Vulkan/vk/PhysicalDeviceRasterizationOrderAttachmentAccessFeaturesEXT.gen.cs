// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT")]
public unsafe partial struct PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("rasterizationOrderColorAttachmentAccess")]
    public MaybeBool<uint> RasterizationOrderColorAttachmentAccess;

    [NativeName("rasterizationOrderDepthAttachmentAccess")]
    public MaybeBool<uint> RasterizationOrderDepthAttachmentAccess;

    [NativeName("rasterizationOrderStencilAttachmentAccess")]
    public MaybeBool<uint> RasterizationOrderStencilAttachmentAccess;

    public PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT() { }
}
