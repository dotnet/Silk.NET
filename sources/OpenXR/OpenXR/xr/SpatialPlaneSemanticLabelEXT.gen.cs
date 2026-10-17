// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPlaneSemanticLabelEXT")]
public enum SpatialPlaneSemanticLabelEXT : uint
{
    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_UNCATEGORIZED_EXT")]
    Uncategorized = 1,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_FLOOR_EXT")]
    Floor = 2,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_WALL_EXT")]
    Wall = 3,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_CEILING_EXT")]
    Ceiling = 4,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_TABLE_EXT")]
    Table = 5,
}
