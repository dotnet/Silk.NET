// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneComputeConsistencyMSFT")]
    public enum SceneComputeConsistencyMSFT : int
    {
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_COMPLETE_MSFT")]
        SceneComputeConsistencySnapshotCompleteMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_SNAPSHOT_INCOMPLETE_FAST_MSFT")]
        SceneComputeConsistencySnapshotIncompleteFastMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPUTE_CONSISTENCY_OCCLUSION_OPTIMIZED_MSFT")]
        SceneComputeConsistencyOcclusionOptimizedMsft = 3,
    }
}
