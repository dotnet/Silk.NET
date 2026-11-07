// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSceneCaptureRequestInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SceneCaptureRequestInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public StructureType Type = StructureType.SceneCaptureRequestInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public void* Next;

    [NativeName("requestByteCount")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public uint RequestByteCount;

    [NativeName("request")]
    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public sbyte* Request;

    [SupportedApiProfile("openxr", ["XR_FB_scene_capture"])]
    public SceneCaptureRequestInfoFB() { }
}
