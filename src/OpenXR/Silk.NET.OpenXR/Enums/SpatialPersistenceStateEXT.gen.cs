// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialPersistenceStateEXT")]
    public enum SpatialPersistenceStateEXT : int
    {
        [Obsolete("Deprecated in favour of \"LoadedExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_STATE_LOADED_EXT")]
        SpatialPersistenceStateLoadedExt = 1,
        [Obsolete("Deprecated in favour of \"NotFoundExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_STATE_NOT_FOUND_EXT")]
        SpatialPersistenceStateNotFoundExt = 2,
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_STATE_LOADED_EXT")]
        LoadedExt = 1,
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_STATE_NOT_FOUND_EXT")]
        NotFoundExt = 2,
    }
}
