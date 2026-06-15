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
    Platform = unchecked((intptr_t)0x1084),

    [NativeName("CL_CONTEXT_INTEROP_USER_SYNC")]
    InteropUserSync = unchecked((intptr_t)0x1085),
}
