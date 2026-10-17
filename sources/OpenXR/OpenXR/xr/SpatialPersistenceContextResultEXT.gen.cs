// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPersistenceContextResultEXT")]
public enum SpatialPersistenceContextResultEXT
{
    [NativeName("XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_SUCCESS_EXT")]
    Success = 0,

    [NativeName("XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_ENTITY_NOT_TRACKING_EXT")]
    EntityNotTracking = -1000781001,

    [NativeName("XR_SPATIAL_PERSISTENCE_CONTEXT_RESULT_PERSIST_UUID_NOT_FOUND_EXT")]
    PersistUuidNotFound = -1000781002,
}
