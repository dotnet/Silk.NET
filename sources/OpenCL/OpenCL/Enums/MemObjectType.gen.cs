// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_object_type")]
public enum MemObjectType : uint
{
    [NativeName("CL_MEM_OBJECT_BUFFER")]
    Buffer = 4336,

    [NativeName("CL_MEM_OBJECT_IMAGE2D")]
    Image2D = 4337,

    [NativeName("CL_MEM_OBJECT_IMAGE3D")]
    Image3D = 4338,

    [NativeName("CL_MEM_OBJECT_IMAGE2D_ARRAY")]
    Image2DArray = 4339,

    [NativeName("CL_MEM_OBJECT_IMAGE1D")]
    Image1D = 4340,

    [NativeName("CL_MEM_OBJECT_IMAGE1D_ARRAY")]
    Image1DArray = 4341,

    [NativeName("CL_MEM_OBJECT_IMAGE1D_BUFFER")]
    Image1DBuffer = 4342,

    [NativeName("CL_MEM_OBJECT_PIPE")]
    Pipe = 4343,
}
