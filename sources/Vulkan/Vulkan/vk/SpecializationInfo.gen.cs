// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSpecializationInfo")]
public unsafe partial struct SpecializationInfo
{
    [NativeName("mapEntryCount")]
    public uint MapEntryCount;

    [NativeName("pMapEntries")]
    public SpecializationMapEntry* PMapEntries;

    [NativeName("dataSize")]
    public nuint DataSize;

    [NativeName("pData")]
    public void* PData;
}
