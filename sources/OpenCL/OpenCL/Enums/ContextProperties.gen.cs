// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_context_properties")]
public enum ContextProperties : long
{
    [NativeName("CL_CONTEXT_PLATFORM")]
    ContextPlatform = 4228,

    [NativeName("CL_CONTEXT_INTEROP_USER_SYNC")]
    ContextInteropUserSync = 4229,

    [NativeName("CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
    ContextMemoryInitializeKHR = 8240,

    [NativeName("CL_CONTEXT_TERMINATE_KHR")]
    ContextTerminateKHR = 8242,

    [NativeName("CL_PRINTF_CALLBACK_ARM")]
    PrintfCallbackARM = 16560,

    [NativeName("CL_PRINTF_BUFFERSIZE_ARM")]
    PrintfBuffersizeARM = 16561,

    [NativeName("CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
    ContextShowDiagnosticsINTEL = 16646,

    [NativeName("CL_CONTEXT_SAFETY_PROPERTIES_IMG")]
    ContextSafetyPropertiesIMG = 16601,
}
