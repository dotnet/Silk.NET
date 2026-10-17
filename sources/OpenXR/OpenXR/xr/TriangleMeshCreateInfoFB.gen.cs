// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTriangleMeshCreateInfoFB")]
public unsafe partial struct TriangleMeshCreateInfoFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.TriangleMeshCreateInfoFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("flags")]
    public TriangleMeshFlagsFB Flags;

    [NativeName("windingOrder")]
    public WindingOrderFB WindingOrder;

    [NativeName("vertexCount")]
    public uint VertexCount;

    [NativeName("vertexBuffer")]
    public Vector3F* VertexBuffer;

    [NativeName("triangleCount")]
    public uint TriangleCount;

    [NativeName("indexBuffer")]
    public uint* IndexBuffer;

    public TriangleMeshCreateInfoFB() { }
}
