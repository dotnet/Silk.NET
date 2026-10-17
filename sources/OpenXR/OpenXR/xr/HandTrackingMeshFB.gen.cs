// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingMeshFB")]
public unsafe partial struct HandTrackingMeshFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.HandTrackingMeshFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("jointCapacityInput")]
    public uint JointCapacityInput;

    [NativeName("jointCountOutput")]
    public uint JointCountOutput;

    [NativeName("jointBindPoses")]
    public Posef* JointBindPoses;

    [NativeName("jointRadii")]
    public float* JointRadii;

    [NativeName("jointParents")]
    public HandJointEXT* JointParents;

    [NativeName("vertexCapacityInput")]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    public uint VertexCountOutput;

    [NativeName("vertexPositions")]
    public Vector3F* VertexPositions;

    [NativeName("vertexNormals")]
    public Vector3F* VertexNormals;

    [NativeName("vertexUVs")]
    public Vector2F* VertexUVs;

    [NativeName("vertexBlendIndices")]
    public Vector4SFB* VertexBlendIndices;

    [NativeName("vertexBlendWeights")]
    public Vector4F* VertexBlendWeights;

    [NativeName("indexCapacityInput")]
    public uint IndexCapacityInput;

    [NativeName("indexCountOutput")]
    public uint IndexCountOutput;

    [NativeName("indices")]
    public short* Indices;

    public HandTrackingMeshFB() { }
}
