// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_mem_cache_type")]
public enum DeviceMemCacheType : uint
{
    [NativeName("CL_NONE")]
    None = 0,

    [NativeName("CL_READ_ONLY_CACHE")]
    ReadOnlyCache = 1,

    [NativeName("CL_READ_WRITE_CACHE")]
    ReadWriteCache = 2,
}
