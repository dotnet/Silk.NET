// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureCreateInfo2KHR")]
public unsafe partial struct AccelerationStructureCreateInfo2KHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureCreateInfo2KHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("createFlags")]
    public AccelerationStructureCreateFlagsKHR CreateFlags;

    [NativeName("addressRange")]
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    [NativeName("type")]
    public AccelerationStructureTypeKHR Type;

    public AccelerationStructureCreateInfo2KHR() { }
}
