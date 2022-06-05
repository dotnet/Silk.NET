// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPassthroughLayerPurposeFB")]
    public enum PassthroughLayerPurposeFB : int
    {
        [Obsolete("Deprecated in favour of \"ReconstructionFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_RECONSTRUCTION_FB")]
        PassthroughLayerPurposeReconstructionFB = 0,
        [Obsolete("Deprecated in favour of \"ProjectedFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_PROJECTED_FB")]
        PassthroughLayerPurposeProjectedFB = 1,
        [Obsolete("Deprecated in favour of \"TrackedKeyboardHandsFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_HANDS_FB")]
        PassthroughLayerPurposeTrackedKeyboardHandsFB = 1000203001,
        [Obsolete("Deprecated in favour of \"TrackedKeyboardMaskedHandsFB\"")]
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_MASKED_HANDS_FB")]
        PassthroughLayerPurposeTrackedKeyboardMaskedHandsFB = 1000203002,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_RECONSTRUCTION_FB")]
        ReconstructionFB = 0,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_PROJECTED_FB")]
        ProjectedFB = 1,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_HANDS_FB")]
        TrackedKeyboardHandsFB = 1000203001,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_MASKED_HANDS_FB")]
        TrackedKeyboardMaskedHandsFB = 1000203002,
    }
}
