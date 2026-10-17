// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceTrackerCreateInfo2FB")]
public unsafe partial struct FaceTrackerCreateInfo2FB
{
    [NativeName("type")]
    public StructureType Type = StructureType.FaceTrackerCreateInfo2FB;

    [NativeName("next")]
    public void* Next;

    [NativeName("faceExpressionSet")]
    public FaceExpressionSet2FB FaceExpressionSet;

    [NativeName("requestedDataSourceCount")]
    public uint RequestedDataSourceCount;

    [NativeName("requestedDataSources")]
    public FaceTrackingDataSource2FB* RequestedDataSources;

    public FaceTrackerCreateInfo2FB() { }
}
