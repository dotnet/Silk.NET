// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceQueryResultsFB")]
public unsafe partial struct SpaceQueryResultsFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpaceQueryResultsFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("resultCapacityInput")]
    public uint ResultCapacityInput;

    [NativeName("resultCountOutput")]
    public uint ResultCountOutput;

    [NativeName("results")]
    public SpaceQueryResultFB* Results;

    public SpaceQueryResultsFB() { }
}
