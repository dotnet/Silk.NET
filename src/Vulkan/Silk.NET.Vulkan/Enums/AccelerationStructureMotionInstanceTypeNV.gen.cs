// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureMotionInstanceTypeNV")]
    public enum AccelerationStructureMotionInstanceTypeNV : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV")]
        AccelerationStructureMotionInstanceTypeStaticNV = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV")]
        AccelerationStructureMotionInstanceTypeMatrixMotionNV = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV")]
        AccelerationStructureMotionInstanceTypeSrtMotionNV = 2,
    }
}
