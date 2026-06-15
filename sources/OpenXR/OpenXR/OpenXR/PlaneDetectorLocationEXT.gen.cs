// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorLocationEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PlaneDetectorLocationEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public StructureType Type = StructureType.TypePlaneDetectorLocationEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public void* Next;

    [NativeName("planeId")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public ulong PlaneId;

    [NativeName("locationFlags")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public SpaceLocationFlags LocationFlags;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public Posef Pose;

    [NativeName("extents")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public Extent2Df Extents;

    [NativeName("orientation")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorOrientationEXT Orientation;

    [NativeName("semanticType")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorSemanticTypeEXT SemanticType;

    [NativeName("polygonBufferCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public uint PolygonBufferCount;

    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    public PlaneDetectorLocationEXT() { }
}
