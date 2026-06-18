// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_external_memory_handle_type_khr")]
public enum ExternalMemoryHandleTypeKHR : uint
{
    [NativeName("CL_EXTERNAL_MEMORY_HANDLE_DMA_BUF_KHR")]
    DmaBuf = 8295,

    [NativeName("CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_FD_KHR")]
    OpaqueFd = 8288,

    [NativeName("CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KHR")]
    OpaqueWin32 = 8289,

    [NativeName("CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KMT_KHR")]
    OpaqueWin32Kmt = 8290,

    [NativeName("CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_NAME_KHR")]
    OpaqueWin32Name = 8297,
}
