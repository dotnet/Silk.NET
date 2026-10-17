// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialEntityComponentDataTriangleMeshBD")]
public unsafe partial struct SpatialEntityComponentDataTriangleMeshBD
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialEntityComponentDataTriangleMeshBD;

    [NativeName("next")]
    public void* Next;

    [NativeName("vertexCapacityInput")]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    public uint VertexCountOutput;

    [NativeName("vertices")]
    public Vector3F* Vertices;

    [NativeName("indexCapacityInput")]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    public uint IndexCountOutput;

    [NativeName("indices")]
    public ushort* Indices;

    public SpatialEntityComponentDataTriangleMeshBD() { }
}
