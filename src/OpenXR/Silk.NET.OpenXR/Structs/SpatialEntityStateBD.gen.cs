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
    [NativeName("Name", "XrSpatialEntityStateBD")]
    public unsafe partial struct SpatialEntityStateBD
    {
        public SpatialEntityStateBD
        (
            StructureType? type = StructureType.TypeSpatialEntityStateBD,
            void* next = null,
            ulong? entityId = null,
            long? lastUpdateTime = null,
            UuidEXT? uuid = null
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

            if (entityId is not null)
            {
                EntityId = entityId.Value;
            }

            if (lastUpdateTime is not null)
            {
                LastUpdateTime = lastUpdateTime.Value;
            }

            if (uuid is not null)
            {
                Uuid = uuid.Value;
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
        [NativeName("Type", "XrSpatialEntityIdBD")]
        [NativeName("Type.Name", "XrSpatialEntityIdBD")]
        [NativeName("Name", "entityId")]
        public ulong EntityId;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastUpdateTime")]
        public long LastUpdateTime;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuid")]
        public UuidEXT Uuid;
    }
}
