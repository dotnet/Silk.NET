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
    [NativeName("Name", "XrLocalizationMapML")]
    public unsafe partial struct LocalizationMapML
    {
        public LocalizationMapML
        (
            StructureType? type = StructureType.TypeLocalizationMapML,
            void* next = null,
            UuidEXT? mapUuid = null,
            LocalizationMapTypeML? mapType = null
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

            if (mapUuid is not null)
            {
                MapUuid = mapUuid.Value;
            }

            if (mapType is not null)
            {
                MapType = mapType.Value;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[64];
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "mapUuid")]
        public UuidEXT MapUuid;
/// <summary></summary>
        [NativeName("Type", "XrLocalizationMapTypeML")]
        [NativeName("Type.Name", "XrLocalizationMapTypeML")]
        [NativeName("Name", "mapType")]
        public LocalizationMapTypeML MapType;
    }
}
