// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_device_terminate_capability_khr")]
    public enum DeviceTerminateCapability : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_TERMINATE_CAPABILITY_CONTEXT_KHR")]
        Context = 0x1,
    }
}
