// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionsSyncInfo")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActionsSyncInfo
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.ActionsSyncInfo;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("countActiveActionSets")]
    [SupportedApiProfile("openxr")]
    public uint CountActiveActionSets;

    [NativeName("activeActionSets")]
    [SupportedApiProfile("openxr")]
    public ActiveActionSet* ActiveActionSets;

    [SupportedApiProfile("openxr")]
    public ActionsSyncInfo() { }
}
