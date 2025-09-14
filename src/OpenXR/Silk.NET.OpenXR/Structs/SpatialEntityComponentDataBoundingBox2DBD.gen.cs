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
    [NativeName("Name", "XrSpatialEntityComponentDataBoundingBox2DBD")]
    public unsafe partial struct SpatialEntityComponentDataBoundingBox2DBD
    {
        public SpatialEntityComponentDataBoundingBox2DBD
        (
            StructureType? type = StructureType.TypeSpatialEntityComponentDataBoundingBox2DBD,
            void* next = null,
            Rect2Df? boundingBox2D = null
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

            if (boundingBox2D is not null)
            {
                BoundingBox2D = boundingBox2D.Value;
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
        [NativeName("Type", "XrRect2Df")]
        [NativeName("Type.Name", "XrRect2Df")]
        [NativeName("Name", "boundingBox2D")]
        public Rect2Df BoundingBox2D;
    }
}
