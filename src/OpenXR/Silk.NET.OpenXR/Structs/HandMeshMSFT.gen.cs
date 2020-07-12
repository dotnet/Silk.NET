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
    public unsafe struct HandMeshMSFT
    {
        public HandMeshMSFT
        (
            StructureType type = StructureType.TypeHandMeshMsft,
            void* next = default,
            uint isActive = default,
            uint indexBufferChanged = default,
            uint vertexBufferChanged = default,
            HandMeshIndexBufferMSFT indexBuffer = default,
            HandMeshVertexBufferMSFT vertexBuffer = default
        )
        {
           Type = type;
           Next = next;
           IsActive = isActive;
           IndexBufferChanged = indexBufferChanged;
           VertexBufferChanged = vertexBufferChanged;
           IndexBuffer = indexBuffer;
           VertexBuffer = vertexBuffer;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint IsActive;
/// <summary></summary>
        public uint IndexBufferChanged;
/// <summary></summary>
        public uint VertexBufferChanged;
/// <summary></summary>
        public HandMeshIndexBufferMSFT IndexBuffer;
/// <summary></summary>
        public HandMeshVertexBufferMSFT VertexBuffer;
    }
}
