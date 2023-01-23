// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [System.Flags]
    [NativeName("Name", "cl_queue_priority_khr")]
    public enum QueuePriority : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_QUEUE_PRIORITY_HIGH_KHR")]
        High = 0x1,
        [NativeName("Name", "CL_QUEUE_PRIORITY_MED_KHR")]
        Med = 0x2,
        [NativeName("Name", "CL_QUEUE_PRIORITY_LOW_KHR")]
        Low = 0x4,
    }
}
