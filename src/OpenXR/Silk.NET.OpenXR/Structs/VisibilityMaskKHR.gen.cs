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
    public unsafe struct VisibilityMaskKHR
    {
        public VisibilityMaskKHR
        (
            StructureType type = StructureType.TypeVisibilityMaskKhr,
            void* next = default,
            uint vertexCapacityInput = default,
            uint vertexCountOutput = default,
            Vector2f* vertices = default,
            uint indexCapacityInput = default,
            uint indexCountOutput = default,
            uint* indices = default
        )
        {
           Type = type;
           Next = next;
           VertexCapacityInput = vertexCapacityInput;
           VertexCountOutput = vertexCountOutput;
           Vertices = vertices;
           IndexCapacityInput = indexCapacityInput;
           IndexCountOutput = indexCountOutput;
           Indices = indices;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint VertexCapacityInput;
/// <summary></summary>
        public uint VertexCountOutput;
/// <summary></summary>
        public Vector2f* Vertices;
/// <summary></summary>
        public uint IndexCapacityInput;
/// <summary></summary>
        public uint IndexCountOutput;
/// <summary></summary>
        public uint* Indices;
    }
}
