// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceMemoryCopyKHR")]
public unsafe partial struct DeviceMemoryCopyKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceMemoryCopyKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcRange")]
    public DeviceAddressRangeKHR SrcRange;

    [NativeName("srcFlags")]
    public AddressCommandFlagsKHR SrcFlags;

    [NativeName("dstRange")]
    public DeviceAddressRangeKHR DstRange;

    [NativeName("dstFlags")]
    public AddressCommandFlagsKHR DstFlags;

    public DeviceMemoryCopyKHR() { }
}
