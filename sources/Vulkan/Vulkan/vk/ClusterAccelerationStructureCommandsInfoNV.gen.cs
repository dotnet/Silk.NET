// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureCommandsInfoNV")]
public unsafe partial struct ClusterAccelerationStructureCommandsInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ClusterAccelerationStructureCommandsInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("input")]
    public ClusterAccelerationStructureInputInfoNV Input;

    [NativeName("dstImplicitData")]
    public ulong DstImplicitData;

    [NativeName("scratchData")]
    public ulong ScratchData;

    [NativeName("dstAddressesArray")]
    public StridedDeviceAddressRegionKHR DstAddressesArray;

    [NativeName("dstSizesArray")]
    public StridedDeviceAddressRegionKHR DstSizesArray;

    [NativeName("srcInfosArray")]
    public StridedDeviceAddressRegionKHR SrcInfosArray;

    [NativeName("srcInfosCount")]
    public ulong SrcInfosCount;

    [NativeName("addressResolutionFlags")]
    public ClusterAccelerationStructureAddressResolutionFlagsNV AddressResolutionFlags;

    public ClusterAccelerationStructureCommandsInfoNV() { }
}
