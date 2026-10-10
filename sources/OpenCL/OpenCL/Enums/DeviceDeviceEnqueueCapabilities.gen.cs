// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_device_device_enqueue_capabilities")]
[Flags]
public enum DeviceDeviceEnqueueCapabilities : ulong
{
    None = 0x0,

    [NativeName("CL_DEVICE_QUEUE_SUPPORTED")]
    Supported = 0x1,

    [NativeName("CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT")]
    ReplaceableDefault = 0x2,
}
