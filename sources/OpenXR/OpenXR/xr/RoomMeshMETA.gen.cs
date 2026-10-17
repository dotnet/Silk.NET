// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRoomMeshMETA")]
public unsafe partial struct RoomMeshMETA
{
    [NativeName("type")]
    public StructureType Type = StructureType.RoomMeshMETA;

    [NativeName("next")]
    public void* Next;

    [NativeName("vertexCapacityInput")]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    public uint VertexCountOutput;

    [NativeName("vertices")]
    public Vector3F* Vertices;

    [NativeName("faceCapacityInput")]
    public uint FaceCapacityInput;

    [NativeName("faceCountOutput")]
    public uint FaceCountOutput;

    [NativeName("faces")]
    public RoomMeshFaceMETA* Faces;

    public RoomMeshMETA() { }
}
