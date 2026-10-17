// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrActionStateVector2f")]
public unsafe partial struct ActionStateVector2F
{
    [NativeName("type")]
    public StructureType Type = StructureType.ActionStateVector2F;

    [NativeName("next")]
    public void* Next;

    [NativeName("currentState")]
    public Vector2F CurrentState;

    [NativeName("changedSinceLastSync")]
    public MaybeBool<uint> ChangedSinceLastSync;

    [NativeName("lastChangeTime")]
    public long LastChangeTime;

    [NativeName("isActive")]
    public MaybeBool<uint> IsActive;

    public ActionStateVector2F() { }
}
