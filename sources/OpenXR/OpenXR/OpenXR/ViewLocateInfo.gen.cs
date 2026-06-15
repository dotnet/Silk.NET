// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrViewLocateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ViewLocateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeViewLocateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("viewConfigurationType")]
    [SupportedApiProfile("openxr")]
    public ViewConfigurationType ViewConfigurationType;

    [NativeName("displayTime")]
    [SupportedApiProfile("openxr")]
    public long DisplayTime;

    [NativeName("space")]
    [SupportedApiProfile("openxr")]
    public SpaceHandle Space;

    [SupportedApiProfile("openxr")]
    public ViewLocateInfo() { }
}
