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
    [NativeName("Name", "XrSpatialAnchorPersistenceInfoMSFT")]
    public unsafe partial struct SpatialAnchorPersistenceInfoMSFT
    {
        public SpatialAnchorPersistenceInfoMSFT
        (
            StructureType? type = StructureType.TypeSpatialAnchorPersistenceInfoMsft,
            void* next = null,
            SpatialAnchorPersistenceNameMSFT? spatialAnchorPersistenceName = null,
            SpatialAnchorMSFT? spatialAnchor = null
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

            if (spatialAnchorPersistenceName is not null)
            {
                SpatialAnchorPersistenceName = spatialAnchorPersistenceName.Value;
            }

            if (spatialAnchor is not null)
            {
                SpatialAnchor = spatialAnchor.Value;
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
        [NativeName("Type", "XrSpatialAnchorPersistenceNameMSFT")]
        [NativeName("Type.Name", "XrSpatialAnchorPersistenceNameMSFT")]
        [NativeName("Name", "spatialAnchorPersistenceName")]
        public SpatialAnchorPersistenceNameMSFT SpatialAnchorPersistenceName;
/// <summary></summary>
        [NativeName("Type", "XrSpatialAnchorMSFT")]
        [NativeName("Type.Name", "XrSpatialAnchorMSFT")]
        [NativeName("Name", "spatialAnchor")]
        public SpatialAnchorMSFT SpatialAnchor;
    }
}
