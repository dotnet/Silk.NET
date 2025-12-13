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
    [NativeName("Name", "XrSpatialUpdateSnapshotCreateInfoEXT")]
    public unsafe partial struct SpatialUpdateSnapshotCreateInfoEXT
    {
        public SpatialUpdateSnapshotCreateInfoEXT
        (
            StructureType? type = StructureType.TypeSpatialUpdateSnapshotCreateInfoExt,
            void* next = null,
            uint? entityCount = null,
            SpatialEntityEXT* entities = null,
            uint? componentTypeCount = null,
            SpatialComponentTypeEXT* componentTypes = null,
            Space? baseSpace = null,
            long? time = null
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

            if (entityCount is not null)
            {
                EntityCount = entityCount.Value;
            }

            if (entities is not null)
            {
                Entities = entities;
            }

            if (componentTypeCount is not null)
            {
                ComponentTypeCount = componentTypeCount.Value;
            }

            if (componentTypes is not null)
            {
                ComponentTypes = componentTypes;
            }

            if (baseSpace is not null)
            {
                BaseSpace = baseSpace.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
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
        [NativeName("Name", "entityCount")]
        public uint EntityCount;
/// <summary></summary>
        [NativeName("Type", "XrSpatialEntityEXT*")]
        [NativeName("Type.Name", "XrSpatialEntityEXT")]
        [NativeName("Name", "entities")]
        public SpatialEntityEXT* Entities;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "componentTypeCount")]
        public uint ComponentTypeCount;
/// <summary></summary>
        [NativeName("Type", "XrSpatialComponentTypeEXT*")]
        [NativeName("Type.Name", "XrSpatialComponentTypeEXT")]
        [NativeName("Name", "componentTypes")]
        public SpatialComponentTypeEXT* ComponentTypes;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "baseSpace")]
        public Space BaseSpace;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
