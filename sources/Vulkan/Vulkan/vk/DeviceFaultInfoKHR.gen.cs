// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceFaultInfoKHR")]
public unsafe partial struct DeviceFaultInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceFaultInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public DeviceFaultFlagsKHR Flags;

    [NativeName("groupId")]
    public ulong GroupId;

    [NativeName("description")]
    public DeviceFaultInfoKHRDescription Description;

    [NativeName("faultAddressInfo")]
    public DeviceFaultAddressInfoKHR FaultAddressInfo;

    [NativeName("instructionAddressInfo")]
    public DeviceFaultAddressInfoKHR InstructionAddressInfo;

    [NativeName("vendorInfo")]
    public DeviceFaultVendorInfoKHR VendorInfo;

    public DeviceFaultInfoKHR() { }
}
