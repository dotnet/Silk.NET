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
    [NativeName("Name", "XrTriangleMeshCreateInfoFB")]
    public unsafe partial struct TriangleMeshCreateInfoFB
    {
        public TriangleMeshCreateInfoFB
        (
            StructureType? type = StructureType.TypeTriangleMeshCreateInfoFB,
            void* next = null,
            TriangleMeshFlagsFB? flags = null,
            WindingOrderFB? windingOrder = null,
            uint? vertexCount = null,
            Vector3f* vertexBuffer = null,
            uint? triangleCount = null,
            uint* indexBuffer = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (windingOrder is not null)
            {
                WindingOrder = windingOrder.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer;
            }

            if (triangleCount is not null)
            {
                TriangleCount = triangleCount.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer;
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
        [NativeName("Type", "XrTriangleMeshFlagsFB")]
        [NativeName("Type.Name", "XrTriangleMeshFlagsFB")]
        [NativeName("Name", "flags")]
        public TriangleMeshFlagsFB Flags;
/// <summary></summary>
        [NativeName("Type", "XrWindingOrderFB")]
        [NativeName("Type.Name", "XrWindingOrderFB")]
        [NativeName("Name", "windingOrder")]
        public WindingOrderFB WindingOrder;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCount")]
        public uint VertexCount;
/// <summary></summary>
        [NativeName("Type", "XrVector3f*")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "vertexBuffer")]
        public Vector3f* VertexBuffer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "triangleCount")]
        public uint TriangleCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexBuffer")]
        public uint* IndexBuffer;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
