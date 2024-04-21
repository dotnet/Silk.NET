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
    [NativeName("Name", "XrSpaceTriangleMeshMETA")]
    public unsafe partial struct SpaceTriangleMeshMETA
    {
        public SpaceTriangleMeshMETA
        (
            StructureType? type = StructureType.TypeSpaceTriangleMeshMeta,
            void* next = null,
            uint? vertexCapacityInput = null,
            uint? vertexCountOutput = null,
            Vector3f* vertices = null,
            uint? indexCapacityInput = null,
            uint? indexCountOutput = null,
            uint* indices = null
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

            if (vertexCapacityInput is not null)
            {
                VertexCapacityInput = vertexCapacityInput.Value;
            }

            if (vertexCountOutput is not null)
            {
                VertexCountOutput = vertexCountOutput.Value;
            }

            if (vertices is not null)
            {
                Vertices = vertices;
            }

            if (indexCapacityInput is not null)
            {
                IndexCapacityInput = indexCapacityInput.Value;
            }

            if (indexCountOutput is not null)
            {
                IndexCountOutput = indexCountOutput.Value;
            }

            if (indices is not null)
            {
                Indices = indices;
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
        [NativeName("Type", "XrVector3f*")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "vertices")]
        public Vector3f* Vertices;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCapacityInput")]
        public uint IndexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCountOutput")]
        public uint IndexCountOutput;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indices")]
        public uint* Indices;
    }
}
