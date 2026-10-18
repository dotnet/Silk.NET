// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerSpaceWarpInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerSpaceWarpInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public StructureType Type = StructureType.CompositionLayerSpaceWarpInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public CompositionLayerSpaceWarpInfoFlagsFB LayerFlags;

    [NativeName("motionVectorSubImage")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public SwapchainSubImage MotionVectorSubImage;

    [NativeName("appSpaceDeltaPose")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public Posef AppSpaceDeltaPose;

    [NativeName("depthSubImage")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public SwapchainSubImage DepthSubImage;

    [NativeName("minDepth")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public float MinDepth;

    [NativeName("maxDepth")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public float MaxDepth;

    [NativeName("nearZ")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public float NearZ;

    [NativeName("farZ")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public float FarZ;

    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public CompositionLayerSpaceWarpInfoFB() { }
}
