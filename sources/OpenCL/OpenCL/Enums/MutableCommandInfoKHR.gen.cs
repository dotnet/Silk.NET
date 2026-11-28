// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_mutable_command_info_khr")]
public enum MutableCommandInfoKHR : uint
{
    [NativeName("CL_MUTABLE_COMMAND_COMMAND_QUEUE_KHR")]
    CommandCommandQueue = 4768,

    [NativeName("CL_MUTABLE_COMMAND_COMMAND_BUFFER_KHR")]
    CommandCommandBuffer = 4769,

    [NativeName("CL_MUTABLE_COMMAND_PROPERTIES_ARRAY_KHR")]
    CommandPropertiesArray = 4770,

    [NativeName("CL_MUTABLE_DISPATCH_KERNEL_KHR")]
    DispatchKernel = 4771,

    [NativeName("CL_MUTABLE_DISPATCH_DIMENSIONS_KHR")]
    DispatchDimensions = 4772,

    [NativeName("CL_MUTABLE_DISPATCH_GLOBAL_WORK_OFFSET_KHR")]
    DispatchGlobalWorkOffset = 4773,

    [NativeName("CL_MUTABLE_DISPATCH_GLOBAL_WORK_SIZE_KHR")]
    DispatchGlobalWorkSize = 4774,

    [NativeName("CL_MUTABLE_DISPATCH_LOCAL_WORK_SIZE_KHR")]
    DispatchLocalWorkSize = 4775,

    [NativeName("CL_MUTABLE_COMMAND_COMMAND_TYPE_KHR")]
    CommandCommandType = 4781,
}
