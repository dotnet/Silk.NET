// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCuLaunchInfoNVX")]
public unsafe partial struct CuLaunchInfoNVX
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CuLaunchInfoNVX;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("function")]
    public CuFunctionHandleNVX Function;

    [NativeName("gridDimX")]
    public uint GridDimX;

    [NativeName("gridDimY")]
    public uint GridDimY;

    [NativeName("gridDimZ")]
    public uint GridDimZ;

    [NativeName("blockDimX")]
    public uint BlockDimX;

    [NativeName("blockDimY")]
    public uint BlockDimY;

    [NativeName("blockDimZ")]
    public uint BlockDimZ;

    [NativeName("sharedMemBytes")]
    public uint SharedMemBytes;

    [NativeName("paramCount")]
    public nuint ParamCount;

    [NativeName("pParams")]
    public void** PParams;

    [NativeName("extraCount")]
    public nuint ExtraCount;

    [NativeName("pExtras")]
    public void** PExtras;

    public CuLaunchInfoNVX() { }
}
