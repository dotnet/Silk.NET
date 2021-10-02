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
    [NativeName("Name", "XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT")]
    public unsafe partial struct SpatialAnchorFromPersistedAnchorCreateInfoMSFT
    {
        public SpatialAnchorFromPersistedAnchorCreateInfoMSFT
        (
            StructureType? type = StructureType.TypeSpatialAnchorFromPersistedAnchorCreateInfoMsft,
            void* next = null,
            SpatialAnchorStoreConnectionMSFT? spatialAnchorStore = null,
            SpatialAnchorPersistenceNameMSFT? spatialAnchorPersistenceName = null
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

            if (spatialAnchorStore is not null)
            {
                SpatialAnchorStore = spatialAnchorStore.Value;
            }

            if (spatialAnchorPersistenceName is not null)
            {
                SpatialAnchorPersistenceName = spatialAnchorPersistenceName.Value;
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
        [NativeName("Type", "XrSpatialAnchorStoreConnectionMSFT")]
        [NativeName("Type.Name", "XrSpatialAnchorStoreConnectionMSFT")]
        [NativeName("Name", "spatialAnchorStore")]
        public SpatialAnchorStoreConnectionMSFT SpatialAnchorStore;
/// <summary></summary>
        [NativeName("Type", "XrSpatialAnchorPersistenceNameMSFT")]
        [NativeName("Type.Name", "XrSpatialAnchorPersistenceNameMSFT")]
        [NativeName("Name", "spatialAnchorPersistenceName")]
        public SpatialAnchorPersistenceNameMSFT SpatialAnchorPersistenceName;
    }
}
