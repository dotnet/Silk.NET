// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRaycastHitResultsANDROID")]
public unsafe partial struct RaycastHitResultsANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.RaycastHitResultsANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("resultsCapacityInput")]
    public uint ResultsCapacityInput;

    [NativeName("resultsCountOutput")]
    public uint ResultsCountOutput;

    [NativeName("results")]
    public RaycastHitResultANDROID* Results;

    public RaycastHitResultsANDROID() { }
}
