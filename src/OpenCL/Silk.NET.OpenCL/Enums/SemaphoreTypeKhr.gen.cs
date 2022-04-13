// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_semaphore_type_khr")]
    public enum SemaphoreTypeKhr : int
    {
        [NativeName("Name", "CL_SEMAPHORE_TYPE_BINARY_KHR")]
        SemaphoreTypeBinaryKhr = 0x1,
    }
}
