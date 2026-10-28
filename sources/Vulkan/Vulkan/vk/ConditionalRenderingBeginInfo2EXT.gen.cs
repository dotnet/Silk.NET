// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkConditionalRenderingBeginInfo2EXT")]
public unsafe partial struct ConditionalRenderingBeginInfo2EXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ConditionalRenderingBeginInfo2EXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("addressRange")]
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    [NativeName("flags")]
    public ConditionalRenderingFlagsEXT Flags;

    public ConditionalRenderingBeginInfo2EXT() { }
}
