// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_semaphore_info_khr")]
public enum SemaphoreInfoKHR : uint
{
    [NativeName("CL_SEMAPHORE_EXPORTABLE_KHR")]
    Exportable = 8276,

    [NativeName("CL_SEMAPHORE_CONTEXT_KHR")]
    Context = 8249,

    [NativeName("CL_SEMAPHORE_REFERENCE_COUNT_KHR")]
    ReferenceCount = 8250,

    [NativeName("CL_SEMAPHORE_PROPERTIES_KHR")]
    Properties = 8251,

    [NativeName("CL_SEMAPHORE_PAYLOAD_KHR")]
    Payload = 8252,
}
