// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableImageFormatANDROID")]
public enum TrackableImageFormatANDROID : uint
{
    [NativeName("XR_TRACKABLE_IMAGE_FORMAT_R8G8B8A8_ANDROID")]
    R8G8B8A8 = 1,
}
