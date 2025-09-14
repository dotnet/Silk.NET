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
    [NativeName("Name", "XrPersistSpatialEntityCompletionEXT")]
    public unsafe partial struct PersistSpatialEntityCompletionEXT
    {
        public PersistSpatialEntityCompletionEXT
        (
            StructureType? type = StructureType.TypePersistSpatialEntityCompletionExt,
            void* next = null,
            Result? futureResult = null,
            SpatialPersistenceContextResultEXT? persistResult = null,
            Uuid? persistUuid = null
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

            if (futureResult is not null)
            {
                FutureResult = futureResult.Value;
            }

            if (persistResult is not null)
            {
                PersistResult = persistResult.Value;
            }

            if (persistUuid is not null)
            {
                PersistUuid = persistUuid.Value;
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
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "futureResult")]
        public Result FutureResult;
/// <summary></summary>
        [NativeName("Type", "XrSpatialPersistenceContextResultEXT")]
        [NativeName("Type.Name", "XrSpatialPersistenceContextResultEXT")]
        [NativeName("Name", "persistResult")]
        public SpatialPersistenceContextResultEXT PersistResult;
/// <summary></summary>
        [NativeName("Type", "XrUuid")]
        [NativeName("Type.Name", "XrUuid")]
        [NativeName("Name", "persistUuid")]
        public Uuid PersistUuid;
    }
}
