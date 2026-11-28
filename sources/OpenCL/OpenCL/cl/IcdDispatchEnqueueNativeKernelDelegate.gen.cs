// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clEnqueueNativeKernel")]
public unsafe delegate int IcdDispatchEnqueueNativeKernelDelegate(
    CommandQueueHandle arg0,
    IcdDispatchClEnqueueNativeKernelP1 arg1,
    void* arg2,
    nuint arg3,
    uint arg4,
    MemHandle* arg5,
    void** arg6,
    uint arg7,
    EventHandle* arg8,
    EventHandle* arg9
);
