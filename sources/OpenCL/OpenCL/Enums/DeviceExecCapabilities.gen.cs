// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_exec_capabilities")]
[Flags]
public enum DeviceExecCapabilities : ulong
{
    None = 0x0,

    [NativeName("CL_EXEC_KERNEL")]
    Kernel = 0x1,

    [NativeName("CL_EXEC_NATIVE_KERNEL")]
    NativeKernel = 0x2,
}
