// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDirectDriverLoadingListLUNARG")]
public unsafe partial struct DirectDriverLoadingListLUNARG
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DirectDriverLoadingListLUNARG;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("mode")]
    public DirectDriverLoadingModeLUNARG Mode;

    [NativeName("driverCount")]
    public uint DriverCount;

    [NativeName("pDrivers")]
    public DirectDriverLoadingInfoLUNARG* PDrivers;

    public DirectDriverLoadingListLUNARG() { }
}
