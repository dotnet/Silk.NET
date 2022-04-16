// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [NativeName("Name", "cl_va_api_device_source_intel")]
    public enum VaApiDeviceSource : int
    {
        [NativeName("Name", "CL_VA_API_DISPLAY_INTEL")]
        Display = 0x4094,
    }
}
