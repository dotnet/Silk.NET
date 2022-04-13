// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_khr_device_uuid")]
    public enum KhrDeviceUuid : int
    {
        [NativeName("Name", "CL_UUID_SIZE_KHR")]
        UuidSizeKhr = 0x16,
        [NativeName("Name", "CL_LUID_SIZE_KHR")]
        LuidSizeKhr = 0x8,
    }
}
