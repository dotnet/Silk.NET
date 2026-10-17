// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughMeshTransformInfoHTC")]
public unsafe partial struct PassthroughMeshTransformInfoHTC
{
    [NativeName("type")]
    public StructureType Type = StructureType.PassthroughMeshTransformInfoHTC;

    [NativeName("next")]
    public void* Next;

    [NativeName("vertexCount")]
    public uint VertexCount;

    [NativeName("vertices")]
    public Vector3F* Vertices;

    [NativeName("indexCount")]
    public uint IndexCount;

    [NativeName("indices")]
    public uint* Indices;

    [NativeName("baseSpace")]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    public long Time;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("scale")]
    public Vector3F Scale;

    public PassthroughMeshTransformInfoHTC() { }
}
