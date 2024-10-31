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
    [NativeName("Name", "XrWorldMeshBlockStateML")]
    public unsafe partial struct WorldMeshBlockStateML
    {
        public WorldMeshBlockStateML
        (
            StructureType? type = StructureType.TypeWorldMeshBlockStateML,
            void* next = null,
            UuidEXT? uuid = null,
            Posef? meshBoundingBoxCenter = null,
            Extent3DfEXT? meshBoundingBoxExtents = null,
            long? lastUpdateTime = null,
            WorldMeshBlockStatusML? status = null
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

            if (meshBoundingBoxCenter is not null)
            {
                MeshBoundingBoxCenter = meshBoundingBoxCenter.Value;
            }

            if (meshBoundingBoxExtents is not null)
            {
                MeshBoundingBoxExtents = meshBoundingBoxExtents.Value;
            }

            if (lastUpdateTime is not null)
            {
                LastUpdateTime = lastUpdateTime.Value;
            }

            if (status is not null)
            {
                Status = status.Value;
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
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "meshBoundingBoxCenter")]
        public Posef MeshBoundingBoxCenter;
/// <summary></summary>
        [NativeName("Type", "XrExtent3DfEXT")]
        [NativeName("Type.Name", "XrExtent3DfEXT")]
        [NativeName("Name", "meshBoundingBoxExtents")]
        public Extent3DfEXT MeshBoundingBoxExtents;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastUpdateTime")]
        public long LastUpdateTime;
/// <summary></summary>
        [NativeName("Type", "XrWorldMeshBlockStatusML")]
        [NativeName("Type.Name", "XrWorldMeshBlockStatusML")]
        [NativeName("Name", "status")]
        public WorldMeshBlockStatusML Status;
    }
}
