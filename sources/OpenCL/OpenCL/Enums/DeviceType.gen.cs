// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_type")]
[Flags]
public enum DeviceType : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_TYPE_DEFAULT")]
    Default = 0x1,

    [NativeName("CL_DEVICE_TYPE_CPU")]
    Cpu = 0x2,

    [NativeName("CL_DEVICE_TYPE_GPU")]
    Gpu = 0x4,

    [NativeName("CL_DEVICE_TYPE_ACCELERATOR")]
    Accelerator = 0x8,

    [NativeName("CL_DEVICE_TYPE_CUSTOM")]
    Custom = 0x10,

    [NativeName("CL_DEVICE_TYPE_ALL")]
    All = 0xFFFFFFFF,
}
