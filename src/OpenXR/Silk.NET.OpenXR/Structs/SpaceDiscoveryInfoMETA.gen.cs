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
    [NativeName("Name", "XrSpaceDiscoveryInfoMETA")]
    public unsafe partial struct SpaceDiscoveryInfoMETA
    {
        public SpaceDiscoveryInfoMETA
        (
            StructureType? type = StructureType.TypeSpaceDiscoveryInfoMeta,
            void* next = null,
            uint? filterCount = null,
            SpaceFilterBaseHeaderMETA* filters = null
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

            if (filterCount is not null)
            {
                FilterCount = filterCount.Value;
            }

            if (filters is not null)
            {
                Filters = filters;
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
        [NativeName("Name", "filterCount")]
        public uint FilterCount;
/// <summary></summary>
        [NativeName("Type", "XrSpaceFilterBaseHeaderMETA*")]
        [NativeName("Type.Name", "XrSpaceFilterBaseHeaderMETA")]
        [NativeName("Name", "filters")]
        public SpaceFilterBaseHeaderMETA* Filters;
    }
}
