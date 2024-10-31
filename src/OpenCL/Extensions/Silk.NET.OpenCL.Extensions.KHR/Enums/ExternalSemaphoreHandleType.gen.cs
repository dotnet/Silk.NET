// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_external_semaphore_handle_type_khr")]
    public enum ExternalSemaphoreHandleType : int
    {
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_FD_KHR")]
        OpaqueFD = 0x2055,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_SYNC_FD_KHR")]
        SyncFD = 0x2058,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_WIN32_KHR")]
        OpaqueWin32 = 0x2056,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        OpaqueWin32Kmt = 0x2057,
        [NativeName("Name", "CL_SEMAPHORE_HANDLE_OPAQUE_WIN32_NAME_KHR")]
        OpaqueWin32Name = 0x2068,
    }
}
