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
    [NativeName("Name", "XrSpaceSaveInfoFB")]
    public unsafe partial struct SpaceSaveInfoFB
    {
        public SpaceSaveInfoFB
        (
            StructureType? type = StructureType.TypeSpaceSaveInfoFB,
            void* next = null,
            Space? space = null,
            SpaceStorageLocationFB? location = null,
            SpacePersistenceModeFB? persistenceMode = null
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

            if (space is not null)
            {
                Space = space.Value;
            }

            if (location is not null)
            {
                Location = location.Value;
            }

            if (persistenceMode is not null)
            {
                PersistenceMode = persistenceMode.Value;
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
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrSpaceStorageLocationFB")]
        [NativeName("Type.Name", "XrSpaceStorageLocationFB")]
        [NativeName("Name", "location")]
        public SpaceStorageLocationFB Location;
/// <summary></summary>
        [NativeName("Type", "XrSpacePersistenceModeFB")]
        [NativeName("Type.Name", "XrSpacePersistenceModeFB")]
        [NativeName("Name", "persistenceMode")]
        public SpacePersistenceModeFB PersistenceMode;
    }
}
