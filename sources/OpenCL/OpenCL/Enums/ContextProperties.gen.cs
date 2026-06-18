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
public enum ContextProperties : intptr_t
{
    [NativeName("CL_CONTEXT_PLATFORM")]
    ContextPlatform = unchecked((intptr_t)0x1084),

    [NativeName("CL_CONTEXT_INTEROP_USER_SYNC")]
    ContextInteropUserSync = unchecked((intptr_t)0x1085),

    [NativeName("CL_CONTEXT_MEMORY_INITIALIZE_KHR")]
    ContextMemoryInitializeKHR = unchecked((intptr_t)0x2030),

    [NativeName("CL_CONTEXT_TERMINATE_KHR")]
    ContextTerminateKHR = unchecked((intptr_t)0x2032),

    [NativeName("CL_PRINTF_CALLBACK_ARM")]
    PrintfCallbackARM = unchecked((intptr_t)0x40B0),

    [NativeName("CL_PRINTF_BUFFERSIZE_ARM")]
    PrintfBuffersizeARM = unchecked((intptr_t)0x40B1),

    [NativeName("CL_CONTEXT_SHOW_DIAGNOSTICS_INTEL")]
    ContextShowDiagnosticsINTEL = unchecked((intptr_t)0x4106),

    [NativeName("CL_CONTEXT_SAFETY_PROPERTIES_IMG")]
    ContextSafetyPropertiesIMG = unchecked((intptr_t)0x40D9),
}
