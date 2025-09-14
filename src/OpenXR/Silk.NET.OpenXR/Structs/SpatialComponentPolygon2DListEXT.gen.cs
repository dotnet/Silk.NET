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
    [NativeName("Name", "XrSpatialComponentPolygon2DListEXT")]
    public unsafe partial struct SpatialComponentPolygon2DListEXT
    {
        public SpatialComponentPolygon2DListEXT
        (
            StructureType? type = StructureType.TypeSpatialComponentPolygon2DListExt,
            void* next = null,
            uint? polygonCount = null,
            SpatialPolygon2DDataEXT* polygons = null
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

            if (polygonCount is not null)
            {
                PolygonCount = polygonCount.Value;
            }

            if (polygons is not null)
            {
                Polygons = polygons;
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
        [NativeName("Name", "polygonCount")]
        public uint PolygonCount;
/// <summary></summary>
        [NativeName("Type", "XrSpatialPolygon2DDataEXT*")]
        [NativeName("Type.Name", "XrSpatialPolygon2DDataEXT")]
        [NativeName("Name", "polygons")]
        public SpatialPolygon2DDataEXT* Polygons;
    }
}
