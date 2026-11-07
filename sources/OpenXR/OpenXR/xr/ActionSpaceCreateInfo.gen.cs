// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionSpaceCreateInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActionSpaceCreateInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.ActionSpaceCreateInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("action")]
    [SupportedApiProfile("openxr")]
    public ActionHandle Action;

    [NativeName("subactionPath")]
    [SupportedApiProfile("openxr")]
    public ulong SubactionPath;

    [NativeName("poseInActionSpace")]
    [SupportedApiProfile("openxr")]
    public Posef PoseInActionSpace;

    [SupportedApiProfile("openxr")]
    public ActionSpaceCreateInfo() { }
}
