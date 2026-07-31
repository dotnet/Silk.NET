// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationView")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ViewConfigurationView
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.ViewConfigurationView;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("recommendedImageRectWidth")]
    [SupportedApiProfile("openxr")]
    public uint RecommendedImageRectWidth;

    [NativeName("maxImageRectWidth")]
    [SupportedApiProfile("openxr")]
    public uint MaxImageRectWidth;

    [NativeName("recommendedImageRectHeight")]
    [SupportedApiProfile("openxr")]
    public uint RecommendedImageRectHeight;

    [NativeName("maxImageRectHeight")]
    [SupportedApiProfile("openxr")]
    public uint MaxImageRectHeight;

    [NativeName("recommendedSwapchainSampleCount")]
    [SupportedApiProfile("openxr")]
    public uint RecommendedSwapchainSampleCount;

    [NativeName("maxSwapchainSampleCount")]
    [SupportedApiProfile("openxr")]
    public uint MaxSwapchainSampleCount;

    [SupportedApiProfile("openxr")]
    public ViewConfigurationView() { }
}
