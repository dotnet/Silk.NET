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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandMeshMSFT")]
    public unsafe partial struct HandMeshMSFT
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "indexBufferChanged")]
        public uint IndexBufferChanged;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "vertexBufferChanged")]
        public uint VertexBufferChanged;
/// <summary></summary>
        [NativeName("Type", "XrHandMeshIndexBufferMSFT")]
        [NativeName("Type.Name", "XrHandMeshIndexBufferMSFT")]
        [NativeName("Name", "indexBuffer")]
        public HandMeshIndexBufferMSFT IndexBuffer;
/// <summary></summary>
        [NativeName("Type", "XrHandMeshVertexBufferMSFT")]
        [NativeName("Type.Name", "XrHandMeshVertexBufferMSFT")]
        [NativeName("Name", "vertexBuffer")]
        public HandMeshVertexBufferMSFT VertexBuffer;
    }
}
