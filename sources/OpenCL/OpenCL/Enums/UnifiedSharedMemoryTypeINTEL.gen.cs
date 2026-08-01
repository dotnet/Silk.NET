// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_unified_shared_memory_type_intel")]
public enum UnifiedSharedMemoryTypeINTEL : uint
{
    [NativeName("CL_MEM_TYPE_UNKNOWN_INTEL")]
    Unknown = 16790,

    [NativeName("CL_MEM_TYPE_HOST_INTEL")]
    Host = 16791,

    [NativeName("CL_MEM_TYPE_DEVICE_INTEL")]
    Device = 16792,

    [NativeName("CL_MEM_TYPE_SHARED_INTEL")]
    Shared = 16793,
}
