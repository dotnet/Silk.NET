// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameSynthesisConfigViewEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FrameSynthesisConfigViewEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public StructureType Type = StructureType.FrameSynthesisConfigViewEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public void* Next;

    [NativeName("recommendedMotionVectorImageRectWidth")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public uint RecommendedMotionVectorImageRectWidth;

    [NativeName("recommendedMotionVectorImageRectHeight")]
    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public uint RecommendedMotionVectorImageRectHeight;

    [SupportedApiProfile("openxr", ["XR_EXT_frame_synthesis"])]
    public FrameSynthesisConfigViewEXT() { }
}
