// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mem_info")]
public enum MemInfo : uint
{
    [NativeName("CL_MEM_TYPE")]
    Type = 4352,

    [NativeName("CL_MEM_FLAGS")]
    Flags = 4353,

    [NativeName("CL_MEM_SIZE")]
    Size = 4354,

    [NativeName("CL_MEM_HOST_PTR")]
    HostPtr = 4355,

    [NativeName("CL_MEM_MAP_COUNT")]
    MapCount = 4356,

    [NativeName("CL_MEM_REFERENCE_COUNT")]
    ReferenceCount = 4357,

    [NativeName("CL_MEM_CONTEXT")]
    Context = 4358,

    [NativeName("CL_MEM_ASSOCIATED_MEMOBJECT")]
    AssociatedMemobject = 4359,

    [NativeName("CL_MEM_OFFSET")]
    Offset = 4360,

    [NativeName("CL_MEM_USES_SVM_POINTER")]
    UsesSvmPointer = 4361,

    [NativeName("CL_MEM_PROPERTIES")]
    Properties = 4362,

    [NativeName("CL_MEM_USES_SVM_POINTER_ARM")]
    UsesSvmPointerARM = 16567,

    [NativeName("CL_MEM_DEVICE_ADDRESS_EXT")]
    DeviceAddressEXT = 20481,
}
