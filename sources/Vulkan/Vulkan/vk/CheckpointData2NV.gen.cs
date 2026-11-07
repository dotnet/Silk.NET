// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCheckpointData2NV")]
public unsafe partial struct CheckpointData2NV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CheckpointData2NV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("stage")]
    public PipelineStageFlags2 Stage;

    [NativeName("pCheckpointMarker")]
    public void* PCheckpointMarker;

    public CheckpointData2NV() { }
}
