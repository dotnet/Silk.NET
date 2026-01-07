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
    [NativeName("Name", "XrSpatialComponentBounded3DListEXT")]
    public unsafe partial struct SpatialComponentBounded3DListEXT
    {
        public SpatialComponentBounded3DListEXT
        (
            StructureType? type = StructureType.TypeSpatialComponentBounded3DListExt,
            void* next = null,
            uint? boundCount = null,
            Boxf* bounds = null
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

            if (boundCount is not null)
            {
                BoundCount = boundCount.Value;
            }

            if (bounds is not null)
            {
                Bounds = bounds;
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
        [NativeName("Name", "boundCount")]
        public uint BoundCount;
/// <summary></summary>
        [NativeName("Type", "XrBoxf*")]
        [NativeName("Type.Name", "XrBoxf")]
        [NativeName("Name", "bounds")]
        public Boxf* Bounds;
    }
}
