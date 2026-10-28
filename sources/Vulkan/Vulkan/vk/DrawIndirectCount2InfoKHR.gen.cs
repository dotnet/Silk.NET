// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDrawIndirectCount2InfoKHR")]
public unsafe partial struct DrawIndirectCount2InfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DrawIndirectCount2InfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("addressRange")]
    public StridedDeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    [NativeName("countAddressRange")]
    public DeviceAddressRangeKHR CountAddressRange;

    [NativeName("countAddressFlags")]
    public AddressCommandFlagsKHR CountAddressFlags;

    [NativeName("maxDrawCount")]
    public uint MaxDrawCount;

    public DrawIndirectCount2InfoKHR() { }
}
