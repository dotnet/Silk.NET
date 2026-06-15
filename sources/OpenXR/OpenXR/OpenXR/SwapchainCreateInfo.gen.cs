// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainCreateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainCreateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeSwapchainCreateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("createFlags")]
    [SupportedApiProfile("openxr")]
    public SwapchainCreateFlags CreateFlags;

    [NativeName("usageFlags")]
    [SupportedApiProfile("openxr")]
    public SwapchainUsageFlags UsageFlags;

    [NativeName("format")]
    [SupportedApiProfile("openxr")]
    public long Format;

    [NativeName("sampleCount")]
    [SupportedApiProfile("openxr")]
    public uint SampleCount;

    [NativeName("width")]
    [SupportedApiProfile("openxr")]
    public uint Width;

    [NativeName("height")]
    [SupportedApiProfile("openxr")]
    public uint Height;

    [NativeName("faceCount")]
    [SupportedApiProfile("openxr")]
    public uint FaceCount;

    [NativeName("arraySize")]
    [SupportedApiProfile("openxr")]
    public uint ArraySize;

    [NativeName("mipCount")]
    [SupportedApiProfile("openxr")]
    public uint MipCount;

    [SupportedApiProfile("openxr")]
    public SwapchainCreateInfo() { }
}
