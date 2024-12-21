// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrWorldMeshDetectorFlagsML")]
    public enum WorldMeshDetectorFlagsML : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PointCloudBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_POINT_CLOUD_BIT_ML")]
        WorldMeshDetectorPointCloudBitML = 1,
        [Obsolete("Deprecated in favour of \"ComputeNormalsBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_COMPUTE_NORMALS_BIT_ML")]
        WorldMeshDetectorComputeNormalsBitML = 2,
        [Obsolete("Deprecated in favour of \"ComputeConfidenceBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_COMPUTE_CONFIDENCE_BIT_ML")]
        WorldMeshDetectorComputeConfidenceBitML = 4,
        [Obsolete("Deprecated in favour of \"PlanarizeBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_PLANARIZE_BIT_ML")]
        WorldMeshDetectorPlanarizeBitML = 8,
        [Obsolete("Deprecated in favour of \"RemoveMeshSkirtBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_REMOVE_MESH_SKIRT_BIT_ML")]
        WorldMeshDetectorRemoveMeshSkirtBitML = 16,
        [Obsolete("Deprecated in favour of \"IndexOrderCWBitML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_INDEX_ORDER_CW_BIT_ML")]
        WorldMeshDetectorIndexOrderCWBitML = 32,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_POINT_CLOUD_BIT_ML")]
        PointCloudBitML = 1,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_COMPUTE_NORMALS_BIT_ML")]
        ComputeNormalsBitML = 2,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_COMPUTE_CONFIDENCE_BIT_ML")]
        ComputeConfidenceBitML = 4,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_PLANARIZE_BIT_ML")]
        PlanarizeBitML = 8,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_REMOVE_MESH_SKIRT_BIT_ML")]
        RemoveMeshSkirtBitML = 16,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_INDEX_ORDER_CW_BIT_ML")]
        IndexOrderCWBitML = 32,
    }
}
