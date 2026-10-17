// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorLocationEXT")]
public unsafe partial struct PlaneDetectorLocationEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.PlaneDetectorLocationEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("planeId")]
    public ulong PlaneId;

    [NativeName("locationFlags")]
    public SpaceLocationFlags LocationFlags;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("extents")]
    public Extent2Df Extents;

    [NativeName("orientation")]
    public PlaneDetectorOrientationEXT Orientation;

    [NativeName("semanticType")]
    public PlaneDetectorSemanticTypeEXT SemanticType;

    [NativeName("polygonBufferCount")]
    public uint PolygonBufferCount;

    public PlaneDetectorLocationEXT() { }
}
