// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBuildPartitionedAccelerationStructureInfoNV")]
public unsafe partial struct BuildPartitionedAccelerationStructureInfoNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BuildPartitionedAccelerationStructureInfoNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("input")]
    public PartitionedAccelerationStructureInstancesInputNV Input;

    [NativeName("srcAccelerationStructureData")]
    public ulong SrcAccelerationStructureData;

    [NativeName("dstAccelerationStructureData")]
    public ulong DstAccelerationStructureData;

    [NativeName("scratchData")]
    public ulong ScratchData;

    [NativeName("srcInfos")]
    public ulong SrcInfos;

    [NativeName("srcInfosCount")]
    public ulong SrcInfosCount;

    public BuildPartitionedAccelerationStructureInfoNV() { }
}
