// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshSnapshotCreateInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneMeshSnapshotCreateInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.TypeSceneMeshSnapshotCreateInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public long Time;

    [NativeName("boundingBox")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Boxf BoundingBox;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshSnapshotCreateInfoANDROID() { }
}
