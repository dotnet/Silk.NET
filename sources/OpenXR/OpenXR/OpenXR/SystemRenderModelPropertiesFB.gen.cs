// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemRenderModelPropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemRenderModelPropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public StructureType Type = StructureType.SystemRenderModelPropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public void* Next;

    [NativeName("supportsRenderModelLoading")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public MaybeBool<uint> SupportsRenderModelLoading;

    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public SystemRenderModelPropertiesFB() { }
}
