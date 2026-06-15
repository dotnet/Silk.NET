// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_sampler_info")]
public enum SamplerInfo : uint
{
    [NativeName("CL_SAMPLER_REFERENCE_COUNT")]
    ReferenceCount = 4432,

    [NativeName("CL_SAMPLER_CONTEXT")]
    ContEXT = 4433,

    [NativeName("CL_SAMPLER_NORMALIZED_COORDS")]
    NormalizedCoords = 4434,

    [NativeName("CL_SAMPLER_ADDRESSING_MODE")]
    AddressingMode = 4435,

    [NativeName("CL_SAMPLER_FILTER_MODE")]
    FilterMode = 4436,

    [NativeName("CL_SAMPLER_MIP_FILTER_MODE")]
    MipFilterMode = 4437,

    [NativeName("CL_SAMPLER_LOD_MIN")]
    LodMin = 4438,

    [NativeName("CL_SAMPLER_LOD_MAX")]
    LodMax = 4439,

    [NativeName("CL_SAMPLER_PROPERTIES")]
    Properties = 4440,
}
