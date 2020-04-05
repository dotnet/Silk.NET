// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public uint PrimitiveCount;
/// <summary></summary>
        public uint PrimitiveOffset;
/// <summary></summary>
        public uint FirstVertex;
/// <summary></summary>
        public uint TransformOffset;
    }
}
