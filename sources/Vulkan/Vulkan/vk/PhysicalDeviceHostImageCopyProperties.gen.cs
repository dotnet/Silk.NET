// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceHostImageCopyProperties")]
public unsafe partial struct PhysicalDeviceHostImageCopyProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceHostImageCopyProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("copySrcLayoutCount")]
    public uint CopySrcLayoutCount;

    [NativeName("pCopySrcLayouts")]
    public ImageLayout* PCopySrcLayouts;

    [NativeName("copyDstLayoutCount")]
    public uint CopyDstLayoutCount;

    [NativeName("pCopyDstLayouts")]
    public ImageLayout* PCopyDstLayouts;

    [NativeName("optimalTilingLayoutUUID")]
    public PhysicalDeviceHostImageCopyPropertiesOptimalTilingLayoutUuid OptimalTilingLayoutUuid;

    [NativeName("identicalMemoryTypeRequirements")]
    public MaybeBool<uint> IdenticalMemoryTypeRequirements;

    public PhysicalDeviceHostImageCopyProperties() { }
}
