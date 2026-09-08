// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshBlockStatusML")]
[SupportedApiProfile("openxr")]
public enum WorldMeshBlockStatusML : uint
{
    [NativeName("XR_WORLD_MESH_BLOCK_STATUS_NEW_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    New = 0,

    [NativeName("XR_WORLD_MESH_BLOCK_STATUS_UPDATED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Updated = 1,

    [NativeName("XR_WORLD_MESH_BLOCK_STATUS_DELETED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Deleted = 2,

    [NativeName("XR_WORLD_MESH_BLOCK_STATUS_UNCHANGED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_world_mesh_detection"], ImpliesSets = ["XR_EXT_future"])]
    Unchanged = 3,
}
