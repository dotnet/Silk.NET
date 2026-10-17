// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrScenePlaneAlignmentTypeMSFT")]
public enum ScenePlaneAlignmentTypeMSFT : uint
{
    [NativeName("XR_SCENE_PLANE_ALIGNMENT_TYPE_NON_ORTHOGONAL_MSFT")]
    NonOrthogonal = 0,

    [NativeName("XR_SCENE_PLANE_ALIGNMENT_TYPE_HORIZONTAL_MSFT")]
    Horizontal = 1,

    [NativeName("XR_SCENE_PLANE_ALIGNMENT_TYPE_VERTICAL_MSFT")]
    Vertical = 2,
}
