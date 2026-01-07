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
    [NativeName("Name", "XrCreateSpatialPersistenceContextCompletionEXT")]
    public unsafe partial struct CreateSpatialPersistenceContextCompletionEXT
    {
        public CreateSpatialPersistenceContextCompletionEXT
        (
            StructureType? type = StructureType.TypeCreateSpatialPersistenceContextCompletionExt,
            void* next = null,
            Result? futureResult = null,
            SpatialPersistenceContextResultEXT? createResult = null,
            SpatialPersistenceContextEXT? persistenceContext = null
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

            if (createResult is not null)
            {
                CreateResult = createResult.Value;
            }

            if (persistenceContext is not null)
            {
                PersistenceContext = persistenceContext.Value;
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
        [NativeName("Name", "createResult")]
        public SpatialPersistenceContextResultEXT CreateResult;
/// <summary></summary>
        [NativeName("Type", "XrSpatialPersistenceContextEXT")]
        [NativeName("Type.Name", "XrSpatialPersistenceContextEXT")]
        [NativeName("Name", "persistenceContext")]
        public SpatialPersistenceContextEXT PersistenceContext;
    }
}
