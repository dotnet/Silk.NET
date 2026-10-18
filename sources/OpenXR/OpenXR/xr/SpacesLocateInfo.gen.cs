// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpacesLocateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpacesLocateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public StructureType Type = StructureType.SpacesLocateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public long Time;

    [NativeName("spaceCount")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public uint SpaceCount;

    [NativeName("spaces")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public SpaceHandle* Spaces;

    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    public SpacesLocateInfo() { }
}
