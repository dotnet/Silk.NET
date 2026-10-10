// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionStateBoolean")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ActionStateBoolean
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.ActionStateBoolean;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("currentState")]
    [SupportedApiProfile("openxr")]
    public MaybeBool<uint> CurrentState;

    [NativeName("changedSinceLastSync")]
    [SupportedApiProfile("openxr")]
    public MaybeBool<uint> ChangedSinceLastSync;

    [NativeName("lastChangeTime")]
    [SupportedApiProfile("openxr")]
    public long LastChangeTime;

    [NativeName("isActive")]
    [SupportedApiProfile("openxr")]
    public MaybeBool<uint> IsActive;

    [SupportedApiProfile("openxr")]
    public ActionStateBoolean() { }
}
