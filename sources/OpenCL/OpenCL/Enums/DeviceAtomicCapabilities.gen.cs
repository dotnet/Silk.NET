// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_atomic_capabilities")]
[Flags]
public enum DeviceAtomicCapabilities : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_ATOMIC_ORDER_RELAXED")]
    OrderRelaxed = 0x1,

    [NativeName("CL_DEVICE_ATOMIC_ORDER_ACQ_REL")]
    OrderAcqRel = 0x2,

    [NativeName("CL_DEVICE_ATOMIC_ORDER_SEQ_CST")]
    OrderSeqCst = 0x4,

    [NativeName("CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM")]
    ScopeWorkItem = 0x8,

    [NativeName("CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP")]
    ScopeWorkGroup = 0x10,

    [NativeName("CL_DEVICE_ATOMIC_SCOPE_DEVICE")]
    ScopeDevice = 0x20,

    [NativeName("CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES")]
    ScopeAllDevices = 0x40,
}
