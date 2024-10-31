// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrWorldMeshBlockStatusML")]
    public enum WorldMeshBlockStatusML : int
    {
        [Obsolete("Deprecated in favour of \"NewML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_NEW_ML")]
        WorldMeshBlockStatusNewML = 0,
        [Obsolete("Deprecated in favour of \"UpdatedML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_UPDATED_ML")]
        WorldMeshBlockStatusUpdatedML = 1,
        [Obsolete("Deprecated in favour of \"DeletedML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_DELETED_ML")]
        WorldMeshBlockStatusDeletedML = 2,
        [Obsolete("Deprecated in favour of \"UnchangedML\"")]
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_UNCHANGED_ML")]
        WorldMeshBlockStatusUnchangedML = 3,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_NEW_ML")]
        NewML = 0,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_UPDATED_ML")]
        UpdatedML = 1,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_DELETED_ML")]
        DeletedML = 2,
        [NativeName("Name", "XR_WORLD_MESH_BLOCK_STATUS_UNCHANGED_ML")]
        UnchangedML = 3,
    }
}
