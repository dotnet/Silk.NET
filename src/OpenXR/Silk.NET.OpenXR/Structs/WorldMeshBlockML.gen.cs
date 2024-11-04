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
    [NativeName("Name", "XrWorldMeshBlockML")]
    public unsafe partial struct WorldMeshBlockML
    {
        public WorldMeshBlockML
        (
            StructureType? type = StructureType.TypeWorldMeshBlockML,
            void* next = null,
            UuidEXT? uuid = null,
            WorldMeshBlockResultML? blockResult = null,
            WorldMeshDetectorLodML? lod = null,
            WorldMeshDetectorFlagsML? flags = null,
            uint? indexCount = null,
            ushort* indexBuffer = null,
            uint? vertexCount = null,
            Vector3f* vertexBuffer = null,
            uint? normalCount = null,
            Vector3f* normalBuffer = null,
            uint? confidenceCount = null,
            float* confidenceBuffer = null
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

            if (uuid is not null)
            {
                Uuid = uuid.Value;
            }

            if (blockResult is not null)
            {
                BlockResult = blockResult.Value;
            }

            if (lod is not null)
            {
                Lod = lod.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (indexCount is not null)
            {
                IndexCount = indexCount.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (vertexBuffer is not null)
            {
                VertexBuffer = vertexBuffer;
            }

            if (normalCount is not null)
            {
                NormalCount = normalCount.Value;
            }

            if (normalBuffer is not null)
            {
                NormalBuffer = normalBuffer;
            }

            if (confidenceCount is not null)
            {
                ConfidenceCount = confidenceCount.Value;
            }

            if (confidenceBuffer is not null)
            {
                ConfidenceBuffer = confidenceBuffer;
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
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuid")]
        public UuidEXT Uuid;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshBlockResultML")]
        [NativeName("Type.Name", "XrWorldMeshBlockResultML")]
        [NativeName("Name", "blockResult")]
        public WorldMeshBlockResultML BlockResult;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshDetectorLodML")]
        [NativeName("Type.Name", "XrWorldMeshDetectorLodML")]
        [NativeName("Name", "lod")]
        public WorldMeshDetectorLodML Lod;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshDetectorFlagsML")]
        [NativeName("Type.Name", "XrWorldMeshDetectorFlagsML")]
        [NativeName("Name", "flags")]
        public WorldMeshDetectorFlagsML Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCount")]
        public uint IndexCount;
/// <summary></summary>
        [NativeName("Type", "uint16_t*")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "indexBuffer")]
        public ushort* IndexBuffer;
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
        [NativeName("Name", "normalCount")]
        public uint NormalCount;
/// <summary></summary>
        [NativeName("Type", "XrVector3f*")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "normalBuffer")]
        public Vector3f* NormalBuffer;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "confidenceCount")]
        public uint ConfidenceCount;
/// <summary></summary>
        [NativeName("Type", "float*")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "confidenceBuffer")]
        public float* ConfidenceBuffer;
    }
}
