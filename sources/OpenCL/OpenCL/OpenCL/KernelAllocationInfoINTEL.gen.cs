// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
namespace Silk.NET.OpenCL;

[NativeName("_cl_kernel_allocation_info_intel")]
public unsafe partial struct KernelAllocationInfoINTEL
{
    [NativeName("@base")]
    public void* @base;

    [NativeName("size")]
    public nuint Size;

    [NativeName("type")]
    public uint Type;

    [NativeName("arg_index")]
    public int ArgIndex;
}
