// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clEnqueueAcquireD3D10ObjectsKHR")]
public unsafe delegate int IcdDispatchWindowsEnqueueAcquireD3D10ObjectsKHRDelegate(
    CommandQueueHandle arg0,
    uint arg1,
    MemHandle* arg2,
    uint arg3,
    EventHandle* arg4,
    EventHandle* arg5
);
