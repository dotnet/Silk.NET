// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_device_local_mem_type")]
    public enum DeviceLocalMemType : int
    {
        [NativeName("Name", "CL_LOCAL")]
        Local = 0x1,
        [NativeName("Name", "CL_GLOBAL")]
        Global = 0x2,
    }
}
