// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialPersistenceContextResultEXT")]
    public enum SpatialPersistenceContextResultEXT : int
    {
        [Obsolete("Deprecated in favour of \"SuccessExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_SUCCESS_EXT")]
        SpatialPersistenceContextResultSuccessExt = 0,
        [Obsolete("Deprecated in favour of \"EntityNotTrackingExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_ENTITY_NOT_TRACKING_EXT")]
        SpatialPersistenceContextResultEntityNotTrackingExt = unchecked((int) -1000781001),
        [Obsolete("Deprecated in favour of \"PersistUuidNotFoundExt\"")]
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_PERSIST_UUID_NOT_FOUND_EXT")]
        SpatialPersistenceContextResultPersistUuidNotFoundExt = unchecked((int) -1000781002),
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_SUCCESS_EXT")]
        SuccessExt = 0,
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_ENTITY_NOT_TRACKING_EXT")]
        EntityNotTrackingExt = unchecked((int) -1000781001),
        [NativeName("Name", "XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_PERSIST_UUID_NOT_FOUND_EXT")]
        PersistUuidNotFoundExt = unchecked((int) -1000781002),
    }
}
