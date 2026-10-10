// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_mem_ext_host_ptr")]
public partial struct MemExtHostPtr
{
    [NativeName("allocation_type")]
    public uint AllocationType;

    [NativeName("host_cache_policy")]
    public uint HostCachePolicy;
}
