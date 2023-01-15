// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_queue_throttle_khr")]
    public enum QueueThrottle : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_QUEUE_THROTTLE_HIGH_KHR")]
        High = 0x1,
        [NativeName("Name", "CL_QUEUE_THROTTLE_MED_KHR")]
        Med = 0x2,
        [NativeName("Name", "CL_QUEUE_THROTTLE_LOW_KHR")]
        Low = 0x4,
    }
}
