// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_semaphore_info_khr")]
    public enum SemaphoreInfo : int
    {
        [NativeName("Name", "CL_SEMAPHORE_CONTEXT_KHR")]
        Context = 0x2039,
        [NativeName("Name", "CL_SEMAPHORE_REFERENCE_COUNT_KHR")]
        ReferenceCount = 0x203A,
        [NativeName("Name", "CL_SEMAPHORE_PROPERTIES_KHR")]
        Properties = 0x203B,
        [NativeName("Name", "CL_SEMAPHORE_PAYLOAD_KHR")]
        Payload = 0x203C,
        [NativeName("Name", "CL_SEMAPHORE_EXPORTABLE_KHR")]
        Exportable = 0x2054,
    }
}
