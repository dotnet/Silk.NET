// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeIntraRefreshCapabilitiesKHR")]
public unsafe partial struct VideoEncodeIntraRefreshCapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeIntraRefreshCapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("intraRefreshModes")]
    public VideoEncodeIntraRefreshModeFlagsKHR IntraRefreshModes;

    [NativeName("maxIntraRefreshCycleDuration")]
    public uint MaxIntraRefreshCycleDuration;

    [NativeName("maxIntraRefreshActiveReferencePictures")]
    public uint MaxIntraRefreshActiveReferencePictures;

    [NativeName("partitionIndependentIntraRefreshRegions")]
    public MaybeBool<uint> PartitionIndependentIntraRefreshRegions;

    [NativeName("nonRectangularIntraRefreshRegions")]
    public MaybeBool<uint> NonRectangularIntraRefreshRegions;

    public VideoEncodeIntraRefreshCapabilitiesKHR() { }
}
