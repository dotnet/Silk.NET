// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_exec_capabilities")]
    public enum DeviceExecCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_EXEC_KERNEL")]
        Kernel = 0x1,
        [NativeName("Name", "CL_EXEC_NATIVE_KERNEL")]
        NativeKernel = 0x2,
    }
}
