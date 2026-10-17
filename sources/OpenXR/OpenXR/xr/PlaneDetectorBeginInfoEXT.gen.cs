// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorBeginInfoEXT")]
public unsafe partial struct PlaneDetectorBeginInfoEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.PlaneDetectorBeginInfoEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("baseSpace")]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    public long Time;

    [NativeName("orientationCount")]
    public uint OrientationCount;

    [NativeName("orientations")]
    public PlaneDetectorOrientationEXT* Orientations;

    [NativeName("semanticTypeCount")]
    public uint SemanticTypeCount;

    [NativeName("semanticTypes")]
    public PlaneDetectorSemanticTypeEXT* SemanticTypes;

    [NativeName("maxPlanes")]
    public uint MaxPlanes;

    [NativeName("minArea")]
    public float MinArea;

    [NativeName("boundingBoxPose")]
    public Posef BoundingBoxPose;

    [NativeName("boundingBoxExtent")]
    public Extent3Df BoundingBoxExtent;

    public PlaneDetectorBeginInfoEXT() { }
}
