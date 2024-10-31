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
    [NativeName("Name", "XrSpacesLocateInfo")]
    [NativeName("Aliases", "XrSpacesLocateInfoKHR")]
    public unsafe partial struct SpacesLocateInfo
    {
        public SpacesLocateInfo
        (
            StructureType? type = StructureType.TypeSpacesLocateInfo,
            void* next = null,
            Space? baseSpace = null,
            long? time = null,
            uint? spaceCount = null,
            Space* spaces = null
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

            if (baseSpace is not null)
            {
                BaseSpace = baseSpace.Value;
            }

            if (time is not null)
            {
                Time = time.Value;
            }

            if (spaceCount is not null)
            {
                SpaceCount = spaceCount.Value;
            }

            if (spaces is not null)
            {
                Spaces = spaces;
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
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "baseSpace")]
        public Space BaseSpace;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "spaceCount")]
        public uint SpaceCount;
/// <summary></summary>
        [NativeName("Type", "XrSpace*")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "spaces")]
        public Space* Spaces;
    }
}
