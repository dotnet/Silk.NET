// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshTrackingStateANDROID")]
public enum SceneMeshTrackingStateANDROID : uint
{
    [NativeName("XR_SCENE_MESH_TRACKING_STATE_INITIALIZING_ANDROID")]
    Initializing = 0,

    [NativeName("XR_SCENE_MESH_TRACKING_STATE_TRACKING_ANDROID")]
    Tracking = 1,

    [NativeName("XR_SCENE_MESH_TRACKING_STATE_WAITING_ANDROID")]
    Waiting = 2,

    [NativeName("XR_SCENE_MESH_TRACKING_STATE_ERROR_ANDROID")]
    Error = 3,
}
