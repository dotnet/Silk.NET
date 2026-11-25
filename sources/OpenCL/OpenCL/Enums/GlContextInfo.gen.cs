// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_gl_context_info")]
public enum GlContextInfo : uint
{
    [NativeName("CL_CURRENT_DEVICE_FOR_GL_CONTEXT_KHR")]
    CurrentDeviceForGlContextKHR = 8198,

    [NativeName("CL_DEVICES_FOR_GL_CONTEXT_KHR")]
    DevicesForGlContextKHR = 8199,
}
