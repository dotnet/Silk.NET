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
    [NativeName("Name", "VkDrawIndirectCommand")]
    public unsafe partial struct DrawIndirectCommand
    {
        public DrawIndirectCommand
        (
            uint? vertexCount = null,
            uint? instanceCount = null,
            uint? firstVertex = null,
            uint? firstInstance = null
        ) : this()
        {
            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (instanceCount is not null)
            {
                InstanceCount = instanceCount.Value;
            }

            if (firstVertex is not null)
            {
                FirstVertex = firstVertex.Value;
            }

            if (firstInstance is not null)
            {
                FirstInstance = firstInstance.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCount")]
        public uint VertexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "instanceCount")]
        public uint InstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstVertex")]
        public uint FirstVertex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstInstance")]
        public uint FirstInstance;
    }
}
