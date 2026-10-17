// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGeometryInstanceCreateInfoFB")]
public unsafe partial struct GeometryInstanceCreateInfoFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.GeometryInstanceCreateInfoFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("layer")]
    public PassthroughLayerHandleFB Layer;

    [NativeName("mesh")]
    public TriangleMeshHandleFB Mesh;

    [NativeName("baseSpace")]
    public SpaceHandle BaseSpace;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("scale")]
    public Vector3F Scale;

    public GeometryInstanceCreateInfoFB() { }
}
