// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkClusterAccelerationStructureClustersBottomLevelInputNV")]
public unsafe partial struct ClusterAccelerationStructureClustersBottomLevelInputNV
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.ClusterAccelerationStructureClustersBottomLevelInputNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxTotalClusterCount")]
    public uint MaxTotalClusterCount;

    [NativeName("maxClusterCountPerAccelerationStructure")]
    public uint MaxClusterCountPerAccelerationStructure;

    public ClusterAccelerationStructureClustersBottomLevelInputNV() { }
}
