// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkAccelerationStructureMotionInstanceDataNV")]
    public unsafe partial struct AccelerationStructureMotionInstanceDataNV
    {
        public AccelerationStructureMotionInstanceDataNV
        (
            AccelerationStructureInstanceKHR? staticInstance = null,
            AccelerationStructureMatrixMotionInstanceNV? matrixMotionInstance = null,
            AccelerationStructureSRTMotionInstanceNV? srtMotionInstance = null
        ) : this()
        {
            if (staticInstance is not null)
            {
                StaticInstance = staticInstance.Value;
            }

            if (matrixMotionInstance is not null)
            {
                MatrixMotionInstance = matrixMotionInstance.Value;
            }

            if (srtMotionInstance is not null)
            {
                SrtMotionInstance = srtMotionInstance.Value;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureInstanceKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureInstanceKHR")]
        [NativeName("Name", "staticInstance")]
        public AccelerationStructureInstanceKHR StaticInstance;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureMatrixMotionInstanceNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMatrixMotionInstanceNV")]
        [NativeName("Name", "matrixMotionInstance")]
        public AccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkAccelerationStructureSRTMotionInstanceNV")]
        [NativeName("Type.Name", "VkAccelerationStructureSRTMotionInstanceNV")]
        [NativeName("Name", "srtMotionInstance")]
        public AccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
    }
}
