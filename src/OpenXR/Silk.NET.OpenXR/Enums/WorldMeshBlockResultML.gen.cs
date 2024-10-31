// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrWorldMeshBlockResultML")]
    public enum WorldMeshBlockResultML : int
    {
        [Obsolete("Deprecated in favour of \"SuccessML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_SUCCESS_ML")]
        WorldMeshBlockResultSuccessML = 0,
        [Obsolete("Deprecated in favour of \"FailedML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_FAILED_ML")]
        WorldMeshBlockResultFailedML = 1,
        [Obsolete("Deprecated in favour of \"PendingML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_PENDING_ML")]
        WorldMeshBlockResultPendingML = 2,
        [Obsolete("Deprecated in favour of \"PartialUpdateML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_PARTIAL_UPDATE_ML")]
        WorldMeshBlockResultPartialUpdateML = 3,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_SUCCESS_ML")]
        SuccessML = 0,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_FAILED_ML")]
        FailedML = 1,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_PENDING_ML")]
        PendingML = 2,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_RESULT_PARTIAL_UPDATE_ML")]
        PartialUpdateML = 3,
    }
}
