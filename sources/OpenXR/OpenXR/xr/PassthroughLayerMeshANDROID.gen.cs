// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughLayerMeshANDROID")]
public unsafe partial struct PassthroughLayerMeshANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.PassthroughLayerMeshANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("windingOrder")]
    public WindingOrderANDROID WindingOrder;

    [NativeName("vertexCount")]
    public uint VertexCount;

    [NativeName("vertices")]
    public Vector3F* Vertices;

    [NativeName("indexCount")]
    public uint IndexCount;

    [NativeName("indices")]
    public ushort* Indices;

    public PassthroughLayerMeshANDROID() { }
}
