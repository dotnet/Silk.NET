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
    [NativeName("Name", "XrSpatialComponentAnchorListEXT")]
    public unsafe partial struct SpatialComponentAnchorListEXT
    {
        public SpatialComponentAnchorListEXT
        (
            StructureType? type = StructureType.TypeSpatialComponentAnchorListExt,
            void* next = null,
            uint? locationCount = null,
            Posef* locations = null
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

            if (locationCount is not null)
            {
                LocationCount = locationCount.Value;
            }

            if (locations is not null)
            {
                Locations = locations;
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
        [NativeName("Name", "locationCount")]
        public uint LocationCount;
/// <summary></summary>
        [NativeName("Type", "XrPosef*")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "locations")]
        public Posef* Locations;
    }
}
