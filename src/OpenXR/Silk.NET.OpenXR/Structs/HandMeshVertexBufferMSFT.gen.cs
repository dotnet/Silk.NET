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

namespace Silk.NET.OpenXR
{
    public unsafe struct HandMeshVertexBufferMSFT
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
        public long VertexUpdateTime;
/// <summary></summary>
        public uint VertexCapacityInput;
/// <summary></summary>
        public uint VertexCountOutput;
/// <summary></summary>
        public HandMeshVertexMSFT* Vertices;
    }
}
