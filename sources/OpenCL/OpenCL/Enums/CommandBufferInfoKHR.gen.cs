// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_command_buffer_info_khr")]
public enum CommandBufferInfoKHR : uint
{
    [NativeName("CL_COMMAND_BUFFER_QUEUES_KHR")]
    Queues = 4756,

    [NativeName("CL_COMMAND_BUFFER_NUM_QUEUES_KHR")]
    NumQueues = 4757,

    [NativeName("CL_COMMAND_BUFFER_REFERENCE_COUNT_KHR")]
    ReferenceCount = 4758,

    [NativeName("CL_COMMAND_BUFFER_STATE_KHR")]
    State = 4759,

    [NativeName("CL_COMMAND_BUFFER_PROPERTIES_ARRAY_KHR")]
    PropertiesArray = 4760,

    [NativeName("CL_COMMAND_BUFFER_CONTEXT_KHR")]
    Context = 4761,
}
