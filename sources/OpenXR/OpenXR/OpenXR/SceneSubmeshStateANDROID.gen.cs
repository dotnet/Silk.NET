// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneSubmeshStateANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneSubmeshStateANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.TypeSceneSubmeshStateANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("submeshId")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Uuid SubmeshId;

    [NativeName("lastUpdatedTime")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public long LastUpdatedTime;

    [NativeName("submeshPoseInBaseSpace")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Posef SubmeshPoseInBaseSpace;

    [NativeName("bounds")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public Extent3Df Bounds;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneSubmeshStateANDROID() { }
}
