// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameSynthesisInfoEXT")]
public unsafe partial struct FrameSynthesisInfoEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.FrameSynthesisInfoEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("layerFlags")]
    public FrameSynthesisInfoFlagsEXT LayerFlags;

    [NativeName("motionVectorSubImage")]
    public SwapchainSubImage MotionVectorSubImage;

    [NativeName("motionVectorScale")]
    public Vector4F MotionVectorScale;

    [NativeName("motionVectorOffset")]
    public Vector4F MotionVectorOffset;

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

    public FrameSynthesisInfoEXT() { }
}
