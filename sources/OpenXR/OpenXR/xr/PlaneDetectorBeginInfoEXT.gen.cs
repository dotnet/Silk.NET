// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorBeginInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PlaneDetectorBeginInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public StructureType Type = StructureType.PlaneDetectorBeginInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public long Time;

    [NativeName("orientationCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public uint OrientationCount;

    [NativeName("orientations")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorOrientationEXT* Orientations;

    [NativeName("semanticTypeCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public uint SemanticTypeCount;

    [NativeName("semanticTypes")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorSemanticTypeEXT* SemanticTypes;

    [NativeName("maxPlanes")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public uint MaxPlanes;

    [NativeName("minArea")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public float MinArea;

    [NativeName("boundingBoxPose")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public Posef BoundingBoxPose;

    [NativeName("boundingBoxExtent")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public Extent3Df BoundingBoxExtent;

    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorBeginInfoEXT() { }
}
