// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerEquirect2KHR")]
public unsafe partial struct CompositionLayerEquirect2KHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerEquirect2KHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerFlags")]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    public EyeVisibility EyeVisibility;

    [NativeName("subImage")]
    public SwapchainSubImage SubImage;

    [NativeName("pose")]
    public Posef Pose;

    [NativeName("radius")]
    public float Radius;

    [NativeName("centralHorizontalAngle")]
    public float CentralHorizontalAngle;

    [NativeName("upperVerticalAngle")]
    public float UpperVerticalAngle;

    [NativeName("lowerVerticalAngle")]
    public float LowerVerticalAngle;

    public CompositionLayerEquirect2KHR() { }
}
