// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandMeshMSFT")]
    public unsafe partial struct HandMeshMSFT
    {
        public HandMeshMSFT
        (
            StructureType? type = StructureType.TypeHandMeshMsft,
            void* next = null,
            uint? isActive = null,
            uint? indexBufferChanged = null,
            uint? vertexBufferChanged = null,
            HandMeshIndexBufferMSFT? indexBuffer = null,
            HandMeshVertexBufferMSFT? vertexBuffer = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (isActive is not null)
            {
                IsActive = isActive.Value;
            }

            if (indexBufferChanged is not null)
            {
                IndexBufferChanged = indexBufferChanged.Value;
            }

            if (vertexBufferChanged is not null)
            {
                VertexBufferChanged = vertexBufferChanged.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer.Value;
            }
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
