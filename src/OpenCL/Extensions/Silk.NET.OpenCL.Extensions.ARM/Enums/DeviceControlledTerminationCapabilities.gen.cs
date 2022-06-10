// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.ARM
{
    [System.Flags]
    [NativeName("Name", "cl_device_controlled_termination_capabilities_arm")]
    public enum DeviceControlledTerminationCapabilities : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_SUCCESS_ARM")]
        Success = 0x1,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_FAILURE_ARM")]
        Failure = 0x2,
        [NativeName("Name", "CL_DEVICE_CONTROLLED_TERMINATION_QUERY_ARM")]
        Query = 0x4,
    }
}
