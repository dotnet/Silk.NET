// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clEnqueueCopyImage")]
public unsafe delegate int IcdDispatchWindowsEnqueueCopyImageDelegate(
    CommandQueueHandle arg0,
    MemHandle arg1,
    MemHandle arg2,
    nuint* arg3,
    nuint* arg4,
    nuint* arg5,
    uint arg6,
    EventHandle* arg7,
    EventHandle* arg8
);
