// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTriangleMeshCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct TriangleMeshCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public StructureType Type = StructureType.TypeTriangleMeshCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public TriangleMeshFlagsFB Flags;

    [NativeName("windingOrder")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public WindingOrderFB WindingOrder;

    [NativeName("vertexCount")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public uint VertexCount;

    [NativeName("vertexBuffer")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public Vector3F* VertexBuffer;

    [NativeName("triangleCount")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public uint TriangleCount;

    [NativeName("indexBuffer")]
    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public uint* IndexBuffer;

    [SupportedApiProfile("openxr", ["XR_FB_triangle_mesh"])]
    public TriangleMeshCreateInfoFB() { }
}
