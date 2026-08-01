// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_alloc_flags_intel")]
[Flags]
public enum MemAllocFlagsINTEL : ulong
{
    None = 0x0,

    [NativeName("CL_MEM_ALLOC_WRITE_COMBINED_INTEL")]
    WriteCombined = 0x1,

    [NativeName("CL_MEM_ALLOC_INITIAL_PLACEMENT_DEVICE_INTEL")]
    InitialPlacementDevice = 0x2,

    [NativeName("CL_MEM_ALLOC_INITIAL_PLACEMENT_HOST_INTEL")]
    InitialPlacementHost = 0x4,
}
