// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct DrawIndirectCommand
    {
        public DrawIndirectCommand
        (
            uint vertexCount = default,
            uint instanceCount = default,
            uint firstVertex = default,
            uint firstInstance = default
        )
        {
           VertexCount = vertexCount;
           InstanceCount = instanceCount;
           FirstVertex = firstVertex;
           FirstInstance = firstInstance;
        }

/// <summary></summary>
        public uint VertexCount;
/// <summary></summary>
        public uint InstanceCount;
/// <summary></summary>
        public uint FirstVertex;
/// <summary></summary>
        public uint FirstInstance;
    }
}
