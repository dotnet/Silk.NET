// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneMeshingTrackerCreateInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneMeshingTrackerCreateInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public StructureType Type = StructureType.TypeSceneMeshingTrackerCreateInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public void* Next;

    [NativeName("semanticLabelSet")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshSemanticLabelSetANDROID SemanticLabelSet;

    [NativeName("enableNormals")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public MaybeBool<uint> EnableNormals;

    [SupportedApiProfile("openxr", ["XR_ANDROID_scene_meshing"])]
    public SceneMeshingTrackerCreateInfoANDROID() { }
}
