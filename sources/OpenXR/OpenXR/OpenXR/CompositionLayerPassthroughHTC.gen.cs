// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerPassthroughHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerPassthroughHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public StructureType Type = StructureType.CompositionLayerPassthroughHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public SpaceHandle Space;

    [NativeName("passthrough")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public PassthroughHandleHTC Passthrough;

    [NativeName("color")]
    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public PassthroughColorHTC Color;

    [SupportedApiProfile("openxr", ["XR_HTC_passthrough"])]
    public CompositionLayerPassthroughHTC() { }
}
