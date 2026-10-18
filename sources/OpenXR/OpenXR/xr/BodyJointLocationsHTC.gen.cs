// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointLocationsHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyJointLocationsHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public StructureType Type = StructureType.BodyJointLocationsHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public void* Next;

    [NativeName("combinedLocationFlags")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public SpaceLocationFlags CombinedLocationFlags;

    [NativeName("confidenceLevel")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodyJointConfidenceHTC ConfidenceLevel;

    [NativeName("jointLocationCount")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public uint JointLocationCount;

    [NativeName("jointLocations")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodyJointLocationHTC* JointLocations;

    [NativeName("skeletonGenerationId")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public uint SkeletonGenerationId;

    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    public BodyJointLocationsHTC() { }
}
