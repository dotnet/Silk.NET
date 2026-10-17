// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewConfigurationView")]
public unsafe partial struct ViewConfigurationView
{
    [NativeName("type")]
    public StructureType Type = StructureType.ViewConfigurationView;

    [NativeName("next")]
    public void* Next;

    [NativeName("recommendedImageRectWidth")]
    public uint RecommendedImageRectWidth;

    [NativeName("maxImageRectWidth")]
    public uint MaxImageRectWidth;

    [NativeName("recommendedImageRectHeight")]
    public uint RecommendedImageRectHeight;

    [NativeName("maxImageRectHeight")]
    public uint MaxImageRectHeight;

    [NativeName("recommendedSwapchainSampleCount")]
    public uint RecommendedSwapchainSampleCount;

    [NativeName("maxSwapchainSampleCount")]
    public uint MaxSwapchainSampleCount;

    public ViewConfigurationView() { }
}
