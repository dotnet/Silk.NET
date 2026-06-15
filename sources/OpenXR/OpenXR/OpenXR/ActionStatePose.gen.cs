// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionStatePose")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActionStatePose
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeActionStatePose;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr")]
    public MaybeBool<uint> IsActive;

    [SupportedApiProfile("openxr")]
    public ActionStatePose() { }
}
