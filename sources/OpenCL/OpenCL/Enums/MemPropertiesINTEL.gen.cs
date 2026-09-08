// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_properties_intel")]
public enum MemPropertiesINTEL : ulong
{
    [NativeName("CL_MEM_ALLOC_FLAGS_INTEL")]
    AllocFlags = 16789,

    [NativeName("CL_MEM_ALLOC_BUFFER_LOCATION_INTEL")]
    AllocBufferLocation = 16798,

    [NativeName("CL_MEM_CHANNEL_INTEL")]
    Channel = 16915,
}
