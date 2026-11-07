// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPartitionedAccelerationStructureWriteInstanceDataNV")]
public partial struct PartitionedAccelerationStructureWriteInstanceDataNV
{
    [NativeName("transform")]
    public TransformMatrixKHR Transform;

    [NativeName("explicitAABB")]
    public PartitionedAccelerationStructureWriteInstanceDataNVExplicitAabb ExplicitAabb;

    [NativeName("instanceID")]
    public uint InstanceID;

    [NativeName("instanceMask")]
    public uint InstanceMask;

    [NativeName("instanceContributionToHitGroupIndex")]
    public uint InstanceContributionToHitGroupIndex;

    [NativeName("instanceFlags")]
    public PartitionedAccelerationStructureInstanceFlagsNV InstanceFlags;

    [NativeName("instanceIndex")]
    public uint InstanceIndex;

    [NativeName("partitionIndex")]
    public uint PartitionIndex;

    [NativeName("accelerationStructure")]
    public ulong AccelerationStructure;
}
