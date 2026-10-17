// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableTypeANDROID")]
public enum TrackableTypeANDROID : uint
{
    [NativeName("XR_TRACKABLE_TYPE_NOT_VALID_ANDROID")]
    NotValid = 0,

    [NativeName("XR_TRACKABLE_TYPE_PLANE_ANDROID")]
    Plane = 1,

    [NativeName("XR_TRACKABLE_TYPE_DEPTH_ANDROID")]
    Depth = 1000463000,

    [NativeName("XR_TRACKABLE_TYPE_OBJECT_ANDROID")]
    Object = 1000466000,

    [NativeName("XR_TRACKABLE_TYPE_MARKER_ANDROID")]
    Marker = 1000707000,

    [NativeName("XR_TRACKABLE_TYPE_QR_CODE_ANDROID")]
    QrCode = 1000708000,

    [NativeName("XR_TRACKABLE_TYPE_IMAGE_ANDROID")]
    Image = 1000709000,
}
