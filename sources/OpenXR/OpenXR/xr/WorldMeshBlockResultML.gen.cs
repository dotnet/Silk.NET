// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshBlockResultML")]
public enum WorldMeshBlockResultML : uint
{
    [NativeName("XR_WORLD_MESH_BLOCK_RESULT_SUCCESS_ML")]
    Success = 0,

    [NativeName("XR_WORLD_MESH_BLOCK_RESULT_FAILED_ML")]
    Failed = 1,

    [NativeName("XR_WORLD_MESH_BLOCK_RESULT_PENDING_ML")]
    Pending = 2,

    [NativeName("XR_WORLD_MESH_BLOCK_RESULT_PARTIAL_UPDATE_ML")]
    PartialUpdate = 3,
}
