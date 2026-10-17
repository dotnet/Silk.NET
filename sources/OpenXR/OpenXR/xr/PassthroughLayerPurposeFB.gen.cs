// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughLayerPurposeFB")]
public enum PassthroughLayerPurposeFB : uint
{
    [NativeName("XR_PASSTHROUGH_LAYER_PURPOSE_RECONSTRUCTION_FB")]
    Reconstruction = 0,

    [NativeName("XR_PASSTHROUGH_LAYER_PURPOSE_PROJECTED_FB")]
    Projected = 1,

    [NativeName("XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_HANDS_FB")]
    TrackedKeyboardHands = 1000203001,

    [NativeName("XR_PASSTHROUGH_LAYER_PURPOSE_TRACKED_KEYBOARD_MASKED_HANDS_FB")]
    TrackedKeyboardMaskedHands = 1000203002,
}
