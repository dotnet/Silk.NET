// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshDetectorLodML")]
[SupportedApiProfile("openxr")]
public enum WorldMeshDetectorLodML : uint
{
    [NativeName("XR_WORLD_MESH_DETECTOR_LOD_MINIMUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Minimum = 0,

    [NativeName("XR_WORLD_MESH_DETECTOR_LOD_MEDIUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Medium = 1,

    [NativeName("XR_WORLD_MESH_DETECTOR_LOD_MAXIMUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Maximum = 2,
}
