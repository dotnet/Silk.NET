// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialPersistenceScopeEXT")]
    public enum SpatialPersistenceScopeEXT : int
    {
        [Obsolete("Deprecated in favour of \"SystemManagedExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_SCOPE_SYSTEM_MANAGED_EXT")]
        SpatialPersistenceScopeSystemManagedExt = 1,
        [Obsolete("Deprecated in favour of \"LocalAnchorsExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_SCOPE_LOCAL_ANCHORS_EXT")]
        SpatialPersistenceScopeLocalAnchorsExt = 1000781000,
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_SCOPE_SYSTEM_MANAGED_EXT")]
        SystemManagedExt = 1,
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_SCOPE_LOCAL_ANCHORS_EXT")]
        LocalAnchorsExt = 1000781000,
    }
}
