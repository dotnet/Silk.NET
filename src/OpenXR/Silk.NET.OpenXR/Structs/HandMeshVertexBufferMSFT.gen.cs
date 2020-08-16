// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandMeshVertexBufferMSFT")]
    public unsafe partial struct HandMeshVertexBufferMSFT
    {
        public HandMeshVertexBufferMSFT
        (
            long vertexUpdateTime = default,
            uint vertexCapacityInput = default,
            uint vertexCountOutput = default,
            HandMeshVertexMSFT* vertices = default
        )
        {
            VertexUpdateTime = vertexUpdateTime;
            VertexCapacityInput = vertexCapacityInput;
            VertexCountOutput = vertexCountOutput;
            Vertices = vertices;
        }

/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "vertexUpdateTime")]
        public long VertexUpdateTime;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCapacityInput")]
        public uint VertexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCountOutput")]
        public uint VertexCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrHandMeshVertexMSFT*")]
        [NativeName("Type.Name", "XrHandMeshVertexMSFT")]
        [NativeName("Name", "vertices")]
        public HandMeshVertexMSFT* Vertices;
    }
}
