// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRenderModelPropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct RenderModelPropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public StructureType Type = StructureType.TypeRenderModelPropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public void* Next;

    [NativeName("vendorId")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public uint VendorId;

    [NativeName("modelName")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public RenderModelPropertiesFBModelName ModelName;

    [NativeName("modelKey")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public ulong ModelKey;

    [NativeName("modelVersion")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public uint ModelVersion;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public RenderModelFlagsFB Flags;

    [SupportedApiProfile("openxr", ["XR_FB_render_model"])]
    public RenderModelPropertiesFB() { }
}
