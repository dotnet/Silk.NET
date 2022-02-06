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
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_RECONSTRUCTION_FB")]
        PassthroughLayerPurposeReconstructionFB = 0,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_PROJECTED_FB")]
        PassthroughLayerPurposeProjectedFB = 1,
        [NativeName("Name", "XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_HANDS_FB")]
        PassthroughLayerPurposeTrackedKeyboardHandsFB = 1000203001,
    }
}
