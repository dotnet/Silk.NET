// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_accelerator_info_intel")]
public enum AcceleratorInfoINTEL : uint
{
    [NativeName("CL_ACCELERATOR_DESCRIPTOR_INTEL")]
    Descriptor = 16528,

    [NativeName("CL_ACCELERATOR_REFERENCE_COUNT_INTEL")]
    ReferenceCount = 16529,

    [NativeName("CL_ACCELERATOR_CONTEXT_INTEL")]
    Context = 16530,

    [NativeName("CL_ACCELERATOR_TYPE_INTEL")]
    Type = 16531,
}
