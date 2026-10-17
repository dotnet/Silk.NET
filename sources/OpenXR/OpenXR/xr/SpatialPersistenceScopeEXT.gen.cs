// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPersistenceScopeEXT")]
public enum SpatialPersistenceScopeEXT : uint
{
    [NativeName("XR_SPATIAL_PERSISTENCE_SCOPE_SYSTEM_MANAGED_EXT")]
    SystemManaged = 1,

    [NativeName("XR_SPATIAL_PERSISTENCE_SCOPE_LOCAL_ANCHORS_EXT")]
    LocalAnchors = 1000781000,
}
