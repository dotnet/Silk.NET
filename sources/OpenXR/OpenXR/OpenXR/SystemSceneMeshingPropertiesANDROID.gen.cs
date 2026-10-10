// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSceneMeshingPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSceneMeshingPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.SystemSceneMeshingPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("supportsSceneMeshing")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public MaybeBool<uint> SupportsSceneMeshing;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SystemSceneMeshingPropertiesANDROID() { }
}
