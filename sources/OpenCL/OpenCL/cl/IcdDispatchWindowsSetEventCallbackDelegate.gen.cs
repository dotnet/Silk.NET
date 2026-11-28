// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows_clSetEventCallback")]
public unsafe delegate int IcdDispatchWindowsSetEventCallbackDelegate(
    EventHandle arg0,
    int arg1,
    IcdDispatchWindowsClSetEventCallbackP2 arg2,
    void* arg3
);
