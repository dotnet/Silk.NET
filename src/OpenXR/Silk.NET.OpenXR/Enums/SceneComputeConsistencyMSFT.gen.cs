// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSceneComputeConsistencyMSFT")]
    public enum SceneComputeConsistencyMSFT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SnapshotCompleteMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_COMPLETE_MSFT")]
        SceneComputeConsistencySnapshotCompleteMsft = 1,
        [Obsolete("Deprecated in favour of \"SnapshotIncompleteFastMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_INCOMPLETE_FAST_MSFT")]
        SceneComputeConsistencySnapshotIncompleteFastMsft = 2,
        [Obsolete("Deprecated in favour of \"OcclusionOptimizedMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_OCCLUSION_OPTIMIZED_MSFT")]
        SceneComputeConsistencyOcclusionOptimizedMsft = 3,
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_COMPLETE_MSFT")]
        SnapshotCompleteMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_INCOMPLETE_FAST_MSFT")]
        SnapshotIncompleteFastMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_OCCLUSION_OPTIMIZED_MSFT")]
        OcclusionOptimizedMsft = 3,
    }
}
