// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_alloc_info_intel")]
public enum MemAllocInfoINTEL : uint
{
    [NativeName("CL_MEM_ALLOC_TYPE_INTEL")]
    Type = 16794,

    [NativeName("CL_MEM_ALLOC_BASE_PTR_INTEL")]
    BasePtr = 16795,

    [NativeName("CL_MEM_ALLOC_SIZE_INTEL")]
    Size = 16796,

    [NativeName("CL_MEM_ALLOC_DEVICE_INTEL")]
    Device = 16797,

    [NativeName("CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
    BufferLocation = 16798,
}
