// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_clCreateFromEGLImageKHR")]
public unsafe delegate MemHandle IcdDispatchCreateFromEglImageKHRDelegate(
    ContextHandle arg0,
    void* arg1,
    void* arg2,
    ulong arg3,
    nint* arg4,
    int* arg5
);
