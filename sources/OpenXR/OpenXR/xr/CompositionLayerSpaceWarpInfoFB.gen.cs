// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerSpaceWarpInfoFB")]
public unsafe partial struct CompositionLayerSpaceWarpInfoFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerSpaceWarpInfoFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerFlags")]
    public CompositionLayerSpaceWarpInfoFlagsFB LayerFlags;

    [NativeName("motionVectorSubImage")]
    public SwapchainSubImage MotionVectorSubImage;

    [NativeName("appSpaceDeltaPose")]
    public Posef AppSpaceDeltaPose;

    [NativeName("depthSubImage")]
    public SwapchainSubImage DepthSubImage;

    [NativeName("minDepth")]
    public float MinDepth;

    [NativeName("maxDepth")]
    public float MaxDepth;

    [NativeName("nearZ")]
    public float NearZ;

    [NativeName("farZ")]
    public float FarZ;

    public CompositionLayerSpaceWarpInfoFB() { }
}
