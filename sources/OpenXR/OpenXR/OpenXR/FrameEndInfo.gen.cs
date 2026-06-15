// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFrameEndInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FrameEndInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeFrameEndInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("displayTime")]
    [SupportedApiProfile("openxr")]
    public long DisplayTime;

    [NativeName("environmentBlendMode")]
    [SupportedApiProfile("openxr")]
    public EnvironmentBlendMode EnvironmentBlendMode;

    [NativeName("layerCount")]
    [SupportedApiProfile("openxr")]
    public uint LayerCount;

    [NativeName("layers")]
    [SupportedApiProfile("openxr")]
    public CompositionLayerBaseHeader** Layers;

    [SupportedApiProfile("openxr")]
    public FrameEndInfo() { }
}
