// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clCreateImage3D")]
public unsafe delegate MemHandle IcdDispatchWindowsCreateImage3DDelegate(
    ContextHandle arg0,
    ulong arg1,
    ImageFormat* arg2,
    nuint arg3,
    nuint arg4,
    nuint arg5,
    nuint arg6,
    nuint arg7,
    void* arg8,
    int* arg9
);
