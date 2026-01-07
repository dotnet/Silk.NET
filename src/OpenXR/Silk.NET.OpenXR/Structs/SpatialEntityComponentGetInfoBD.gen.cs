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
    [NativeName("Name", "XrSpatialEntityComponentGetInfoBD")]
    public unsafe partial struct SpatialEntityComponentGetInfoBD
    {
        public SpatialEntityComponentGetInfoBD
        (
            StructureType? type = StructureType.TypeSpatialEntityComponentGetInfoBD,
            void* next = null,
            ulong? entityId = null,
            SpatialEntityComponentTypeBD? componentType = null
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

            if (componentType is not null)
            {
                ComponentType = componentType.Value;
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
        [NativeName("Type", "XrSpatialEntityComponentTypeBD")]
        [NativeName("Type.Name", "XrSpatialEntityComponentTypeBD")]
        [NativeName("Name", "componentType")]
        public SpatialEntityComponentTypeBD ComponentType;
    }
}
