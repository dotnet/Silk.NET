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
    [NativeName("Name", "VkAccelerationStructureMotionInstanceNV")]
    public unsafe partial struct AccelerationStructureMotionInstanceNV
    {
        public AccelerationStructureMotionInstanceNV
        (
            AccelerationStructureMotionInstanceTypeNV? type = null,
            uint? flags = null,
            AccelerationStructureMotionInstanceDataNV? data = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureMotionInstanceTypeNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMotionInstanceTypeNV")]
        [NativeName("Name", "type")]
        public AccelerationStructureMotionInstanceTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureMotionInstanceFlagsNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMotionInstanceFlagsNV")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureMotionInstanceDataNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMotionInstanceDataNV")]
        [NativeName("Name", "data")]
        public AccelerationStructureMotionInstanceDataNV Data;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
