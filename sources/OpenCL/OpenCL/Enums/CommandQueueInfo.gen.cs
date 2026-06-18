// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_queue_info")]
public enum CommandQueueInfo : uint
{
    [NativeName("CL_QUEUE_CONTEXT")]
    Context = 4240,

    [NativeName("CL_QUEUE_DEVICE")]
    Device = 4241,

    [NativeName("CL_QUEUE_REFERENCE_COUNT")]
    ReferenceCount = 4242,

    [NativeName("CL_QUEUE_PROPERTIES")]
    Properties = 4243,

    [NativeName("CL_QUEUE_SIZE")]
    Size = 4244,

    [NativeName("CL_QUEUE_DEVICE_DEFAULT")]
    DeviceDefault = 4245,

    [NativeName("CL_QUEUE_PROPERTIES_ARRAY")]
    PropertiesArray = 4248,
}
