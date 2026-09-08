// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughMeshTransformInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughMeshTransformInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public StructureType Type = StructureType.PassthroughMeshTransformInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public void* Next;

    [NativeName("vertexCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public uint VertexCount;

    [NativeName("vertices")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public Vector3F* Vertices;

    [NativeName("indexCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public uint IndexCount;

    [NativeName("indices")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public uint* Indices;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public long Time;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public Posef Pose;

    [NativeName("scale")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public Vector3F Scale;

    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public PassthroughMeshTransformInfoHTC() { }
}
