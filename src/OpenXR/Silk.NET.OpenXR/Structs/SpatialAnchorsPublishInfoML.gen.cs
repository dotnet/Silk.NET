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
    [NativeName("Name", "XrSpatialAnchorsPublishInfoML")]
    public unsafe partial struct SpatialAnchorsPublishInfoML
    {
        public SpatialAnchorsPublishInfoML
        (
            StructureType? type = StructureType.TypeSpatialAnchorsPublishInfoML,
            void* next = null,
            uint? anchorCount = null,
            Space* anchors = null,
            ulong? expiration = null
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

            if (anchorCount is not null)
            {
                AnchorCount = anchorCount.Value;
            }

            if (anchors is not null)
            {
                Anchors = anchors;
            }

            if (expiration is not null)
            {
                Expiration = expiration.Value;
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
        [NativeName("Name", "anchorCount")]
        public uint AnchorCount;
/// <summary></summary>
        [NativeName("Type", "XrSpace*")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "anchors")]
        public Space* Anchors;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "expiration")]
        public ulong Expiration;
    }
}
