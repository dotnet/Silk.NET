// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSceneComputeStateMSFT")]
    public enum SceneComputeStateMSFT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NoneMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_NONE_MSFT")]
        SceneComputeStateNoneMsft = 0,
        [Obsolete("Deprecated in favour of \"UpdatingMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_UPDATING_MSFT")]
        SceneComputeStateUpdatingMsft = 1,
        [Obsolete("Deprecated in favour of \"CompletedMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_COMPLETED_MSFT")]
        SceneComputeStateCompletedMsft = 2,
        [Obsolete("Deprecated in favour of \"CompletedWithErrorMsft\"")]
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_COMPLETED_WITH_ERROR_MSFT")]
        SceneComputeStateCompletedWithErrorMsft = 3,
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_NONE_MSFT")]
        NoneMsft = 0,
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_UPDATING_MSFT")]
        UpdatingMsft = 1,
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_COMPLETED_MSFT")]
        CompletedMsft = 2,
        [NativeName("Name", "XR_SCENE_COMPUTE_STATE_COMPLETED_WITH_ERROR_MSFT")]
        CompletedWithErrorMsft = 3,
    }
}
