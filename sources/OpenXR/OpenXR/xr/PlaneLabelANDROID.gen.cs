// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneLabelANDROID")]
public enum PlaneLabelANDROID : uint
{
    [NativeName("XR_PLANE_LABEL_UNKNOWN_ANDROID")]
    Unknown = 0,

    [NativeName("XR_PLANE_LABEL_WALL_ANDROID")]
    Wall = 1,

    [NativeName("XR_PLANE_LABEL_FLOOR_ANDROID")]
    Floor = 2,

    [NativeName("XR_PLANE_LABEL_CEILING_ANDROID")]
    Ceiling = 3,

    [NativeName("XR_PLANE_LABEL_TABLE_ANDROID")]
    Table = 4,
}
