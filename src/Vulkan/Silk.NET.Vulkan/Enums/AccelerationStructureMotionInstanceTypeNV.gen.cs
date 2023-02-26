// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccelerationStructureMotionInstanceTypeNV")]
    public enum AccelerationStructureMotionInstanceTypeNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"StaticNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV")]
        AccelerationStructureMotionInstanceTypeStaticNV = 0,
        [Obsolete("Deprecated in favour of \"MatrixMotionNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV")]
        AccelerationStructureMotionInstanceTypeMatrixMotionNV = 1,
        [Obsolete("Deprecated in favour of \"SrtMotionNV\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV")]
        AccelerationStructureMotionInstanceTypeSrtMotionNV = 2,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV")]
        StaticNV = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV")]
        MatrixMotionNV = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV")]
        SrtMotionNV = 2,
    }
}
