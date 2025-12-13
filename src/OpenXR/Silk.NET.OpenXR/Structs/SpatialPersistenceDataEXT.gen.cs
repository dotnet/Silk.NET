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
    [NativeName("Name", "XrSpatialPersistenceDataEXT")]
    public unsafe partial struct SpatialPersistenceDataEXT
    {
        public SpatialPersistenceDataEXT
        (
            Uuid? persistUuid = null,
            SpatialPersistenceStateEXT? persistState = null
        ) : this()
        {
            if (persistUuid is not null)
            {
                PersistUuid = persistUuid.Value;
            }

            if (persistState is not null)
            {
                PersistState = persistState.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrUuid")]
        [NativeName("Type.Name", "XrUuid")]
        [NativeName("Name", "persistUuid")]
        public Uuid PersistUuid;
/// <summary></summary>
        [NativeName("Type", "XrSpatialPersistenceStateEXT")]
        [NativeName("Type.Name", "XrSpatialPersistenceStateEXT")]
        [NativeName("Name", "persistState")]
        public SpatialPersistenceStateEXT PersistState;
    }
}
