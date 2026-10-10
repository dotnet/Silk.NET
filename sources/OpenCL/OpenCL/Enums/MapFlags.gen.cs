// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_map_flags")]
[Flags]
public enum MapFlags : ulong
{
    None = 0x0,

    [NativeName("CL_MAP_READ")]
    Read = 0x1,

    [NativeName("CL_MAP_WRITE")]
    Write = 0x2,

    [NativeName("CL_MAP_WRITE_INVALIDATE_REGION")]
    WriteInvalidateRegion = 0x4,
}
