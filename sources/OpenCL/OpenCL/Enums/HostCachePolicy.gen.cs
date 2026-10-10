// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("host_cache_policy")]
public enum HostCachePolicy : uint
{
    [NativeName("CL_MEM_HOST_UNCACHED_QCOM")]
    UncachedQCOM = 16548,

    [NativeName("CL_MEM_HOST_WRITEBACK_QCOM")]
    WritebackQCOM = 16549,

    [NativeName("CL_MEM_HOST_WRITETHROUGH_QCOM")]
    WritethroughQCOM = 16550,

    [NativeName("CL_MEM_HOST_WRITE_COMBINING_QCOM")]
    WriteCombiningQCOM = 16551,

    [NativeName("CL_MEM_HOST_IOCOHERENT_QCOM")]
    IocoherentQCOM = 16553,
}
