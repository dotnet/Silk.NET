// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_semaphore_properties_khr")]
    public enum SemaphoreProperties : ulong
    {
        [NativeName("Name", "CL_SEMAPHORE_EXPORT_HANDLE_TYPES_KHR")]
        ExportHandleTypes = 0x203F,
    }
}
