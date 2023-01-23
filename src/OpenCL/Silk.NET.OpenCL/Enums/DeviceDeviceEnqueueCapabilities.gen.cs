// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [System.Flags]
    [NativeName("Name", "cl_device_device_enqueue_capabilities")]
    public enum DeviceDeviceEnqueueCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_QUEUE_SUPPORTED")]
        Supported = 0x1,
        [NativeName("Name", "CL_DEVICE_QUEUE_REPLACEABLE_DEFAULT")]
        ReplaceableDefault = 0x2,
    }
}
