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
    public unsafe struct DrawIndexedIndirectCommand
    {
        public DrawIndexedIndirectCommand
        (
            uint indexCount = default,
            uint instanceCount = default,
            uint firstIndex = default,
            int vertexOffset = default,
            uint firstInstance = default
        )
        {
           IndexCount = indexCount;
           InstanceCount = instanceCount;
           FirstIndex = firstIndex;
           VertexOffset = vertexOffset;
           FirstInstance = firstInstance;
        }

/// <summary></summary>
        public uint IndexCount;
/// <summary></summary>
        public uint InstanceCount;
/// <summary></summary>
        public uint FirstIndex;
/// <summary></summary>
        public int VertexOffset;
/// <summary></summary>
        public uint FirstInstance;
    }
}
