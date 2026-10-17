// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshBlockML")]
public unsafe partial struct WorldMeshBlockML
{
    [NativeName("type")]
    public StructureType Type = StructureType.WorldMeshBlockML;

    [NativeName("next")]
    public void* Next;

    [NativeName("uuid")]
    public Uuid Uuid;

    [NativeName("blockResult")]
    public WorldMeshBlockResultML BlockResult;

    [NativeName("lod")]
    public WorldMeshDetectorLodML Lod;

    [NativeName("flags")]
    public WorldMeshDetectorFlagsML Flags;

    [NativeName("indexCount")]
    public uint IndexCount;

    [NativeName("indexBuffer")]
    public ushort* IndexBuffer;

    [NativeName("vertexCount")]
    public uint VertexCount;

    [NativeName("vertexBuffer")]
    public Vector3F* VertexBuffer;

    [NativeName("normalCount")]
    public uint NormalCount;

    [NativeName("normalBuffer")]
    public Vector3F* NormalBuffer;

    [NativeName("confidenceCount")]
    public uint ConfidenceCount;

    [NativeName("confidenceBuffer")]
    public float* ConfidenceBuffer;

    public WorldMeshBlockML() { }
}
