// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaPerfBlockPropertiesAMD")]
public partial struct GpaPerfBlockPropertiesAMD
{
    [NativeName("blockType")]
    public GpaPerfBlockAMD BlockType;

    [NativeName("flags")]
    public uint Flags;

    [NativeName("instanceCount")]
    public uint InstanceCount;

    [NativeName("maxEventID")]
    public uint MaxEventID;

    [NativeName("maxGlobalOnlyCounters")]
    public uint MaxGlobalOnlyCounters;

    [NativeName("maxGlobalSharedCounters")]
    public uint MaxGlobalSharedCounters;

    [NativeName("maxStreamingCounters")]
    public uint MaxStreamingCounters;
}
