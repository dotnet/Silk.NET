// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableImageTrackingModeANDROID")]
public enum TrackableImageTrackingModeANDROID : uint
{
    [NativeName("XR_TRACKABLE_IMAGE_TRACKING_MODE_DYNAMIC_ANDROID")]
    Dynamic = 1,

    [NativeName("XR_TRACKABLE_IMAGE_TRACKING_MODE_STATIC_ANDROID")]
    Static = 2,
}
