// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_external_memory_handle_type_khr")]
    public enum ExternalMemoryHandleType : int
    {
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_DMA_BUF_KHR")]
        DmaBuf = 0x2067,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_FD_KHR")]
        OpaqueFD = 0x2060,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KHR")]
        OpaqueWin32 = 0x2061,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        OpaqueWin32Kmt = 0x2062,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_NAME_KHR")]
        OpaqueWin32Name = 0x2069,
    }
}
