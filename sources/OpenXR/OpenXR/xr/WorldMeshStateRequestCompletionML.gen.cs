// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWorldMeshStateRequestCompletionML")]
public unsafe partial struct WorldMeshStateRequestCompletionML
{
    [NativeName("type")]
    public StructureType Type = StructureType.WorldMeshStateRequestCompletionML;

    [NativeName("next")]
    public void* Next;

    [NativeName("futureResult")]
    public Result FutureResult;

    [NativeName("timestamp")]
    public long Timestamp;

    [NativeName("meshBlockStateCapacityInput")]
    public uint MeshBlockStateCapacityInput;

    [NativeName("meshBlockStateCountOutput")]
    public uint MeshBlockStateCountOutput;

    [NativeName("meshBlockStates")]
    public WorldMeshBlockStateML* MeshBlockStates;

    public WorldMeshStateRequestCompletionML() { }
}
