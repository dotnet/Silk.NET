// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceMemoryImageCopyKHR")]
public unsafe partial struct DeviceMemoryImageCopyKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceMemoryImageCopyKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("addressRange")]
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    [NativeName("addressRowLength")]
    public uint AddressRowLength;

    [NativeName("addressImageHeight")]
    public uint AddressImageHeight;

    [NativeName("imageSubresource")]
    public ImageSubresourceLayers ImageSubresource;

    [NativeName("imageLayout")]
    public ImageLayout ImageLayout;

    [NativeName("imageOffset")]
    public Offset3D ImageOffset;

    [NativeName("imageExtent")]
    public Extent3D ImageExtent;

    public DeviceMemoryImageCopyKHR() { }
}
