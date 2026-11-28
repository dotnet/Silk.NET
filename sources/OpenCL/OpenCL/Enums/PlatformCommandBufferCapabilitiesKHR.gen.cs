// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_platform_command_buffer_capabilities_khr")]
[Flags]
public enum PlatformCommandBufferCapabilitiesKHR : ulong
{
    None = 0x0,

    [NativeName("CL_COMMAND_BUFFER_PLATFORM_UNIVERSAL_SYNC_KHR")]
    UniversalSync = 0x1,

    [NativeName("CL_COMMAND_BUFFER_PLATFORM_REMAP_QUEUES_KHR")]
    RemapQueues = 0x2,

    [NativeName("CL_COMMAND_BUFFER_PLATFORM_AUTOMATIC_REMAP_KHR")]
    AutomaticRemap = 0x4,
}
