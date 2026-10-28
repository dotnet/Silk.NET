// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindVertexBuffer3InfoKHR")]
public unsafe partial struct BindVertexBuffer3InfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindVertexBuffer3InfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("setStride")]
    public MaybeBool<uint> SetStride;

    [NativeName("addressRange")]
    public StridedDeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    public AddressCommandFlagsKHR AddressFlags;

    public BindVertexBuffer3InfoKHR() { }
}
