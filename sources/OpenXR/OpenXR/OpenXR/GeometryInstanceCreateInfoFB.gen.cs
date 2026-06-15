// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGeometryInstanceCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GeometryInstanceCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public StructureType Type = StructureType.TypeGeometryInstanceCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public void* Next;

    [NativeName("layer")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughLayerHandleFB Layer;

    [NativeName("mesh")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public TriangleMeshHandleFB Mesh;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public SpaceHandle BaseSpace;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public Posef Pose;

    [NativeName("scale")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public Vector3F Scale;

    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public GeometryInstanceCreateInfoFB() { }
}
