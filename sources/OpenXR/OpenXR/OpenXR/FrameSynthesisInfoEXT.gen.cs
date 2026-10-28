// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameSynthesisInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FrameSynthesisInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public StructureType Type = StructureType.FrameSynthesisInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public FrameSynthesisInfoFlagsEXT LayerFlags;

    [NativeName("motionVectorSubImage")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public SwapchainSubImage MotionVectorSubImage;

    [NativeName("motionVectorScale")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public Vector4F MotionVectorScale;

    [NativeName("motionVectorOffset")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public Vector4F MotionVectorOffset;

    [NativeName("appSpaceDeltaPose")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public Posef AppSpaceDeltaPose;

    [NativeName("depthSubImage")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public SwapchainSubImage DepthSubImage;

    [NativeName("minDepth")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public float MinDepth;

    [NativeName("maxDepth")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public float MaxDepth;

    [NativeName("nearZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public float NearZ;

    [NativeName("farZ")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public float FarZ;

    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public FrameSynthesisInfoEXT() { }
}
