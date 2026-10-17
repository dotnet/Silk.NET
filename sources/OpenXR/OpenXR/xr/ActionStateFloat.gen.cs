// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionStateFloat")]
public unsafe partial struct ActionStateFloat
{
    [NativeName("type")]
    public StructureType Type = StructureType.ActionStateFloat;

    [NativeName("next")]
    public void* Next;

    [NativeName("currentState")]
    public float CurrentState;

    [NativeName("changedSinceLastSync")]
    public MaybeBool<uint> ChangedSinceLastSync;

    [NativeName("lastChangeTime")]
    public long LastChangeTime;

    [NativeName("isActive")]
    public MaybeBool<uint> IsActive;

    public ActionStateFloat() { }
}
