// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkAccelerationStructureBuildRangeInfoKHR")]
    public unsafe partial struct AccelerationStructureBuildRangeInfoKHR
    {
        public AccelerationStructureBuildRangeInfoKHR
        (
            uint? primitiveCount = null,
            uint? primitiveOffset = null,
            uint? firstVertex = null,
            uint? transformOffset = null
        ) : this()
        {
            if (primitiveCount is not null)
            {
                PrimitiveCount = primitiveCount.Value;
            }

            if (primitiveOffset is not null)
            {
                PrimitiveOffset = primitiveOffset.Value;
            }

            if (firstVertex is not null)
            {
                FirstVertex = firstVertex.Value;
            }

            if (transformOffset is not null)
            {
                TransformOffset = transformOffset.Value;
            }
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
