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
    [NativeName("Name", "XrSenseDataProviderCreateInfoSpatialMeshBD")]
    public unsafe partial struct SenseDataProviderCreateInfoSpatialMeshBD
    {
        public SenseDataProviderCreateInfoSpatialMeshBD
        (
            StructureType? type = StructureType.TypeSenseDataProviderCreateInfoSpatialMeshBD,
            void* next = null,
            SpatialMeshConfigFlagsBD? configFlags = null,
            SpatialMeshLodBD? lod = null
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

            if (configFlags is not null)
            {
                ConfigFlags = configFlags.Value;
            }

            if (lod is not null)
            {
                Lod = lod.Value;
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
        [NativeName("Type", "XrSpatialMeshConfigFlagsBD")]
        [NativeName("Type.Name", "XrSpatialMeshConfigFlagsBD")]
        [NativeName("Name", "configFlags")]
        public SpatialMeshConfigFlagsBD ConfigFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpatialMeshLodBD")]
        [NativeName("Type.Name", "XrSpatialMeshLodBD")]
        [NativeName("Name", "lod")]
        public SpatialMeshLodBD Lod;
    }
}
