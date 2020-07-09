// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureBuildOffsetInfoKHR")]
    public unsafe struct AccelerationStructureBuildOffsetInfoKHR
    {
        public AccelerationStructureBuildOffsetInfoKHR
        (
            uint primitiveCount = default,
            uint primitiveOffset = default,
            uint firstVertex = default,
            uint transformOffset = default
        )
        {
           PrimitiveCount = primitiveCount;
           PrimitiveOffset = primitiveOffset;
           FirstVertex = firstVertex;
           TransformOffset = transformOffset;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "primitiveCount")]
        public uint PrimitiveCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "primitiveOffset")]
        public uint PrimitiveOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstVertex")]
        public uint FirstVertex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "transformOffset")]
        public uint TransformOffset;
    }
}
