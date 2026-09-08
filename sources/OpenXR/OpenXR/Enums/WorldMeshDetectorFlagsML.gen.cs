// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshDetectorFlagsML")]
[Flags]
public enum WorldMeshDetectorFlagsML : ulong
{
    None = 0x0,

    [NativeName("XR_WORLD_MESH_DETECTOR_POINT_CLOUD_BIT_ML")]
    PointCloudBit = 0x1,

    [NativeName("XR_WORLD_MESH_DETECTOR_COMPUTE_NORMALS_BIT_ML")]
    ComputeNormalsBit = 0x2,

    [NativeName("XR_WORLD_MESH_DETECTOR_COMPUTE_CONFIDENCE_BIT_ML")]
    ComputeConfidenceBit = 0x4,

    [NativeName("XR_WORLD_MESH_DETECTOR_PLANARIZE_BIT_ML")]
    PlanarizeBit = 0x8,

    [NativeName("XR_WORLD_MESH_DETECTOR_REMOVE_MESH_SKIRT_BIT_ML")]
    RemoveMeshSkirtBit = 0x10,

    [NativeName("XR_WORLD_MESH_DETECTOR_INDEX_ORDER_CW_BIT_ML")]
    IndexOrderCwBit = 0x20,
}
