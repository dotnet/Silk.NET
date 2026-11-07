// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDispatchIndirect2InfoKHR")]
public unsafe partial struct DispatchIndirect2InfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DispatchIndirect2InfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("addressRange")]
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    public DispatchIndirect2InfoKHR() { }
}
