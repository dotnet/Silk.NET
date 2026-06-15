// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_platform_info")]
public enum PlatformInfo : uint
{
    [NativeName("CL_PLATFORM_PROFILE")]
    Profile = 2304,

    [NativeName("CL_PLATFORM_VERSION")]
    Version = 2305,

    [NativeName("CL_PLATFORM_NAME")]
    Name = 2306,

    [NativeName("CL_PLATFORM_VENDOR")]
    Vendor = 2307,

    [NativeName("CL_PLATFORM_EXTENSIONS")]
    Extensions = 2308,

    [NativeName("CL_PLATFORM_HOST_TIMER_RESOLUTION")]
    HostTimerResolution = 2309,

    [NativeName("CL_PLATFORM_NUMERIC_VERSION")]
    NumericVersion = 2310,

    [NativeName("CL_PLATFORM_EXTENSIONS_WITH_VERSION")]
    ExtensionsWithVersion = 2311,
}
