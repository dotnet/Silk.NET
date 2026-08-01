// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshSnapshotCreationResultANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneMeshSnapshotCreationResultANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.SceneMeshSnapshotCreationResultANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("snapshot")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshSnapshotHandleANDROID Snapshot;

    [NativeName("trackingState")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshTrackingStateANDROID TrackingState;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshSnapshotCreationResultANDROID() { }
}
